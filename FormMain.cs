using System.IO.Ports;
using NModbus;

namespace mobbus_rtu_scaner
{
    public partial class FormMain : Form
    {
        private bool isScanning = false;
        private CancellationTokenSource? cancellationTokenSource;

        public FormMain()
        {
            InitializeComponent();

            InitializeNLog();

            // get list of all sort and sort order (e.g., COM1, COM2, ..., COM10)
            var sortedPorts = SerialPort.GetPortNames()
                .Select(port => new
                {
                    PortName = port,
                    PortNumber = int.TryParse(port.Replace("COM", ""), out int num) ? num : int.MaxValue
                })
                .OrderBy(p => p.PortNumber)
                .Select(p => p.PortName)
                .ToArray();


            ToolStripComboBoxPorts.Items.AddRange(sortedPorts);

            // select the first port by default if available
            if (ToolStripComboBoxPorts.Items.Count > 0)
            {
                ToolStripComboBoxPorts.SelectedIndex = 0;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // populate ToolStripComboBoxDeviceID with device IDs from 0 to 240
            for (int i = 0; i <= 247; i++)
            {
                ToolStripComboBoxDeviceID.Items.Add(i);
            }

            // select device ID 1 by default
            ToolStripComboBoxDeviceID.SelectedItem = 1;

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // populate CheckedListBoxBuadRate with all baud rates
            int[] baudRates = [1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 56000, 57600, 115200, 128000, 230400, 256000, 460800, 921600];
            foreach (var baudRate in baudRates)
            {
                CheckedListBoxBuadRate.Items.Add(baudRate);
            }

            

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // populate CheckedListBoxDatabit with all data bit options
            int[] dataBits = [5, 6, 7, 8];
            foreach (var dataBit in dataBits)
            {
                CheckedListBoxDatabit.Items.Add(dataBit);
            }

            

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // populate CheckedListBoxStopbit with all stop bit options
            StopBits[] stopBits = [StopBits.One, StopBits.OnePointFive, StopBits.Two];
            foreach (var stopBit in stopBits)
            {
                CheckedListBoxStopbit.Items.Add(stopBit);
            }

            

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // populate CheckedListBoxParity with all parity options
            Parity[] parities = [Parity.None, Parity.Odd, Parity.Even, Parity.Mark, Parity.Space];
            foreach (var parity in parities)
            {
                CheckedListBoxParity.Items.Add(parity);
            }

            

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            Handshake[] handshakes = [Handshake.None, Handshake.XOnXOff, Handshake.RequestToSend, Handshake.RequestToSendXOnXOff];
            foreach (var handshake in handshakes)
            {
                CheckedListBoxHandshake.Items.Add(handshake);
            }

            

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // populate CheckedListBoxModbusFunctions with all Modbus function codes
            int[] modbusFunctions = [1, 2, 3, 4, 5, 6, 15, 16];
            foreach (var function in modbusFunctions)
            {
                // display function code and name (e.g., "1 - Read Coils")
                string functionName = function switch
                {
                    1 => "Read Coils",
                    2 => "Read Discrete Inputs",
                    3 => "Read Holding Registers",
                    4 => "Read Input Registers",
                    5 => "Write Single Coil",
                    6 => "Write Single Register",
                    15 => "Write Multiple Coils",
                    16 => "Write Multiple Registers",
                    _ => "Unknown"
                };

                CheckedListBoxModbusFunctions.Items.Add($"{function} - {functionName}");
            }

            

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ToolStripButtonStopScan.Enabled = false;
        }


        private void CheckDefaultSettings()
        {
            // check common baud rates by default
            int[] commonBaudRates = [9600, 19200, 38400, 57600, 115200];
            for (int i = 0; i < CheckedListBoxBuadRate.Items.Count; i++)
            {
                if (commonBaudRates.Contains((int)CheckedListBoxBuadRate.Items[i]))
                {
                    CheckedListBoxBuadRate.SetItemChecked(i, true);
                }
            }

            // check common data bits by default (7 and 8)
            int[] commonDataBits = [8];
            for (int i = 0; i < CheckedListBoxDatabit.Items.Count; i++)
            {
                if (commonDataBits.Contains((int)CheckedListBoxDatabit.Items[i]))
                {
                    CheckedListBoxDatabit.SetItemChecked(i, true);
                }
            }

            // check common stop bits by default (One and Two)
            StopBits[] commonStopBits = [StopBits.One];
            for (int i = 0; i < CheckedListBoxStopbit.Items.Count; i++)
            {
                if (commonStopBits.Contains((StopBits)CheckedListBoxStopbit.Items[i]))
                {
                    CheckedListBoxStopbit.SetItemChecked(i, true);
                }
            }

            // check common parity options by default (None, Even, Odd)
            Parity[] commonParities = [Parity.None];
            for (int i = 0; i < CheckedListBoxParity.Items.Count; i++)
            {
                if (commonParities.Contains((Parity)CheckedListBoxParity.Items[i]))
                {
                    CheckedListBoxParity.SetItemChecked(i, true);
                }
            }

            // check common handshake options by default (None)
            Handshake[] commonHandshakes = [Handshake.None, Handshake.RequestToSend];
            for (int i = 0; i < CheckedListBoxHandshake.Items.Count; i++)
            {
                if (commonHandshakes.Contains((Handshake)CheckedListBoxHandshake.Items[i]))
                {
                    CheckedListBoxHandshake.SetItemChecked(i, true);
                }
            }

            CheckedListBoxModbusFunctions.SetItemChecked(2, true);
        }

        private void InitializeNLog()
        {
            // target rotating log file in the application directory
            var config = new NLog.Config.LoggingConfiguration();

            var logFile = new NLog.Targets.FileTarget("logfile")
            {
                FileName = "${basedir}/logs/logfile.log",
                Layout = "${longdate} ${level} ${message} ${exception}",
                ArchiveEvery = NLog.Targets.FileArchivePeriod.Day,
                MaxArchiveFiles = 7
            };

            config.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal, logFile);

            NLog.LogManager.Configuration = config;
        }

        private async void ToolStripButtonStartScan_Click(object sender, EventArgs e)
        {
            TextBoxLogger.Clear();
            ToolStripProgressBarScan.Value = 0;

            if (ToolStripComboBoxPorts.SelectedItem == null)
            {
                MessageBox.Show("Please select a serial port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedPort = ToolStripComboBoxPorts.SelectedItem.ToString()!;


            int[] baudRates = CheckedListBoxBuadRate.CheckedItems.Cast<int>().ToArray();
            int[] dataBits = CheckedListBoxDatabit.CheckedItems.Cast<int>().ToArray();
            Parity[] parities = CheckedListBoxParity.CheckedItems.Cast<Parity>().ToArray();
            StopBits[] stopBits = CheckedListBoxStopbit.CheckedItems.Cast<StopBits>().ToArray();
            Handshake[] handshakes = CheckedListBoxHandshake.CheckedItems.Cast<Handshake>().ToArray();

            if (baudRates.Length == 0)
            {
                MessageBox.Show("Please select at least one baud rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataBits.Length == 0)
            {
                MessageBox.Show("Please select at least one data bit option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (parities.Length == 0)
            {
                MessageBox.Show("Please select at least one parity option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (stopBits.Length == 0)
            {
                MessageBox.Show("Please select at least one stop bit option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (handshakes.Length == 0)
            {
                MessageBox.Show("Please select at least one handshake option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // calculate total combinations for progress tracking in second. timeout 500 ms, so 0.5 second per combination
            int totalCombinations = baudRates.Length * dataBits.Length * parities.Length * stopBits.Length * handshakes.Length;
            TimeSpan estimatedTime = TimeSpan.FromSeconds(totalCombinations * 0.5);

            var result = MessageBox.Show($"This scan will test {totalCombinations} configurations and may take approximately {estimatedTime.TotalMinutes:F2} minutes. Do you want to proceed?", "Confirm Scan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            ToolStripButtonStartScan.Enabled = false;
            ToolStripButtonStopScan.Enabled = true;
            ToolStripComboBoxPorts.Enabled = false;
            ToolStripComboBoxDeviceID.Enabled = false;
            isScanning = true;

            cancellationTokenSource = new CancellationTokenSource();

            try
            {
                await ScanModbusDeviceAsync(selectedPort, cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                LogMessage("Scan cancelled by user.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during scan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToolStripButtonStartScan.Enabled = true;
                ToolStripButtonStopScan.Enabled = false;
                ToolStripComboBoxPorts.Enabled = true;
                ToolStripComboBoxDeviceID.Enabled = true;
                isScanning = false;
                cancellationTokenSource?.Dispose();
                cancellationTokenSource = null;
            }
        }

        private void ToolStripButtonStopScan_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource != null && !cancellationTokenSource.IsCancellationRequested)
            {
                cancellationTokenSource.Cancel();
                LogMessage("Cancelling scan...");
            }

            ToolStripProgressBarScan.Value = 0;
        }

        private double GetTotalCombinations()
        {
            double baudRatesCount = CheckedListBoxBuadRate.CheckedItems.Count;
            double dataBitsCount = CheckedListBoxDatabit.CheckedItems.Count;
            double paritiesCount = CheckedListBoxParity.CheckedItems.Count;
            double stopBitsCount = CheckedListBoxStopbit.CheckedItems.Count;
            double handshakesCount = CheckedListBoxHandshake.CheckedItems.Count;
            double modbusFunctionsCount = CheckedListBoxModbusFunctions.CheckedItems.Count;
            double totalCombinations = baudRatesCount * dataBitsCount * paritiesCount * stopBitsCount * handshakesCount * modbusFunctionsCount;
            return totalCombinations;
        }

        private TimeSpan GetEstimatedTime()
        {
            double totalCombinations = GetTotalCombinations();
            return TimeSpan.FromSeconds(totalCombinations * 0.5);
        }


        private async Task ScanModbusDeviceAsync(string portName, CancellationToken cancellationToken)
        {
            LogMessage($"Starting scan on {portName}...");
            LogMessage("----------------------------------------");

            int[] baudRates = CheckedListBoxBuadRate.CheckedItems.Cast<int>().ToArray();
            int[] dataBits = CheckedListBoxDatabit.CheckedItems.Cast<int>().ToArray();
            Parity[] parities = CheckedListBoxParity.CheckedItems.Cast<Parity>().ToArray();
            StopBits[] stopBits = CheckedListBoxStopbit.CheckedItems.Cast<StopBits>().ToArray();
            Handshake[] handshakes = CheckedListBoxHandshake.CheckedItems.Cast<Handshake>().ToArray();
            string[] modbusFunctions = CheckedListBoxModbusFunctions.CheckedItems.Cast<string>().ToArray();

            TimeSpan estimatedTime = GetEstimatedTime();
            TimeSpan interval = TimeSpan.FromSeconds(0.5);

            ToolStripProgressBarScan.Value = 0;
            ToolStripProgressBarScan.Maximum = (int)GetTotalCombinations() + 1;

            byte slaveId = ToolStripComboBoxDeviceID.SelectedItem != null ? Convert.ToByte(ToolStripComboBoxDeviceID.SelectedItem) : (byte)1;

            foreach (var handshake in handshakes)
            {
                foreach (var parity in parities)
                {
                    foreach (var stopBit in stopBits)
                    {
                        foreach (var dataBit in dataBits)
                        {
                            foreach (var baudRate in baudRates)
                            {
                                foreach (var modbusFunction in modbusFunctions)
                                {
                                    // switch to selected Modbus function code (e.g., "3 - Read Holding Registers" -> 3)
                                    int functionCode = int.Parse(modbusFunction.Split('-')[0].Trim());

                                    if (cancellationToken.IsCancellationRequested)
                                    {
                                        return;
                                    }

                                    ToolStripProgressBarScan.Value++;
                                    estimatedTime = estimatedTime.Subtract(interval);

                                    await TryConfigurationAsync(functionCode, portName, baudRate, dataBit, parity, stopBit, handshake, slaveId, cancellationToken);

                                    toolStripStatusLabelEstimatedTtimeRremaining.Text = $"Estimated time remaining: {estimatedTime:mm\\:ss}";
                                }
                            }
                        }
                    }
                }
            }

            ToolStripProgressBarScan.Value = 0;

            LogMessage("----------------------------------------");
            LogMessage("Scan completed.");
        }

        private async Task TryConfigurationAsync(int modbus_function, string portName, int baudRate, int dataBits, Parity parity, StopBits stopBits, Handshake handshake, byte slaveId, CancellationToken cancellationToken)
        {
            SerialPort? serialPort = null;

            try
            {
                string config = $"SlaveID:{slaveId}, Function:{modbus_function}, {portName} {baudRate},{dataBits},{parity},{stopBits},{handshake}";

                LogMessage($"Testing: {config}");

                serialPort = new SerialPort(portName)
                {
                    BaudRate = baudRate,
                    DataBits = dataBits,
                    Parity = parity,
                    StopBits = stopBits,
                    Handshake = handshake,
                    ReadTimeout = 500,
                    WriteTimeout = 500
                };

                serialPort.Open();

                var factory = new ModbusFactory();
                var adapter = new SerialPortAdapter(serialPort);
                IModbusSerialMaster master = factory.CreateRtuMaster(adapter);

                ushort startAddress = 0;
                ushort numRegisters = 1;

                bool[]? coils = null;
                ushort[]? registers = null;

                switch (modbus_function)
                {
                    case 1:
                        coils = await Task.Run(() => master.ReadCoils(slaveId, startAddress, numRegisters), cancellationToken);
                        break;

                    case 2:
                        coils = await Task.Run(() => master.ReadInputs(slaveId, startAddress, numRegisters), cancellationToken);
                        break;

                    case 3:
                        registers = await Task.Run(() => master.ReadHoldingRegisters(slaveId, startAddress, numRegisters), cancellationToken);
                        break;

                    case 4:
                        registers = await Task.Run(() => master.ReadInputRegisters(slaveId, startAddress, numRegisters), cancellationToken);
                        break;

                    case 5:
                        await Task.Run(() => master.WriteSingleCoil(slaveId, startAddress, true), cancellationToken);
                        break;

                    case 6:
                        await Task.Run(() => master.WriteSingleRegister(slaveId, startAddress, 12345), cancellationToken);
                        break;

                    case 15:
                        bool[] coilValues = new bool[numRegisters];
                        for (int i = 0; i < numRegisters; i++)
                        {
                            coilValues[i] = true;
                        }
                        await Task.Run(() => master.WriteMultipleCoils(slaveId, startAddress, coilValues), cancellationToken);
                        break;

                    case 16:
                        ushort[] registerValues = new ushort[numRegisters];
                        for (int i = 0; i < numRegisters; i++)
                        {
                            registerValues[i] = 12345;
                        }
                        await Task.Run(() => master.WriteMultipleRegisters(slaveId, startAddress, registerValues), cancellationToken);
                        break;

                    default:
                        LogMessage($"Unsupported Modbus function code: {modbus_function}");
                        return;
                }

                LogMessage($"✓ SUCCESS: Device found! {config}");
                LogMessage("");
            }
            catch (TimeoutException)
            {
                LogMessage($"Timeout: from device {portName}.");
            }
            catch (InvalidOperationException)
            {
                LogMessage($"Invalid operation: Port {portName} is not open.");
            }
            catch (IOException)
            {
                LogMessage($"I/O error: Unable to communicate with {portName}.");
            }
            catch (UnauthorizedAccessException ex)
            {
                LogMessage($"✗ Port access denied: {ex.Message}");
            }
            catch (Exception ex)
            {
                LogMessage($"✗ Error: {ex.Message}");
            }
            finally
            {
                if (serialPort?.IsOpen == true)
                {
                    serialPort.Close();
                }
                serialPort?.Dispose();
            }
        }

        private void LogMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(() => LogMessage(message));
                return;
            }

            NLog.LogManager.GetCurrentClassLogger().Info(message);
            TextBoxLogger.AppendText(message + Environment.NewLine);

            // make sure the latest log entry is visible
            TextBoxLogger.SelectionStart = TextBoxLogger.Text.Length;
            TextBoxLogger.ScrollToCaret();
        }


        private void SetupInformation()
        {
            double totalCombinations = GetTotalCombinations();
            textBoxTotalCombinations.Text = $"Total Combinations: {totalCombinations}";
            TimeSpan estimatedTime = GetEstimatedTime();
            textBoxEstimatedTime.Text = $"Estimated Time: {estimatedTime:mm\\:ss}";
        }

        private void ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                this.BeginInvoke((MethodInvoker)delegate
                    {
                        SetupInformation();
                    });
            }
            catch (Exception)
            {
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            CheckDefaultSettings();
            SetupInformation();
        }
    }
}
