# Modbus RTU Scanner

A Windows Forms application for scanning and detecting Modbus RTU devices on serial ports with various communication parameters.

## Overview

Modbus RTU Scanner is a diagnostic tool that helps you identify the correct communication settings for Modbus RTU devices. It systematically tests different combinations of serial port parameters (baud rate, data bits, parity, stop bits, and handshake) to find working configurations.

## Features

- **Serial Port Detection**: Automatically detects and lists available COM ports
- **Configurable Parameters**: Test multiple combinations of:
  - Baud Rates: 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 56000, 57600, 115200, 128000, 230400, 256000, 460800, 921600
  - Data Bits: 5, 6, 7, 8
  - Parity: None, Odd, Even, Mark, Space
  - Stop Bits: One, OnePointFive, Two
  - Handshake: None, XOnXOff, RequestToSend, RequestToSendXOnXOff
  - Modbus Functions: 
    - 01 - Read Coils
    - 02 - Read Discrete Inputs
    - 03 - Read Holding Registers
    - 04 - Read Input Registers
    - 05 - Write Single Coil
    - 06 - Write Single Register
    - 15 - Write Multiple Coils
    - 16 - Write Multiple Registers
    - 17 - Report Slave ID
    - 20 - Read File Record
    - 21 - Write File Record
    - 22 - Mask Write Register
    - 23 - Read/Write Multiple Registers
    - 24 - Read FIFO Queue
- **Device ID Selection**: Scan for specific Modbus slave IDs (0-240)
- **Progress Tracking**: Visual progress bar showing scan progress
- **Real-time Logging**: View scan results in real-time with file logging support
- **Cancellable Scans**: Stop ongoing scans at any time
- **Time Estimation**: Provides estimated scan duration before starting

## Requirements

- .NET 10
- Windows operating system
- Serial port access permissions
- NModbus library
- NLog library

## Usage

1. **Select Serial Port**: Choose the COM port where your Modbus device is connected
2. **Select Device ID**: Choose the Modbus slave ID to scan (default: 1)
3. **Configure Parameters**: Check the communication parameters you want to test:
   - Default common settings are pre-selected
   - Select multiple options to test more combinations
   - Choose which Modbus functions to test (default: 03 - Read Holding Registers)
4. **Start Scan**: Click "Start Scan" to begin
   - The application will show estimated scan time
   - Confirm to proceed
5. **Monitor Progress**: Watch the progress bar and log output
6. **Review Results**: Successful configurations are marked with ✓ SUCCESS

## Technical Details

- Built with Windows Forms (.NET 10)
- Uses NModbus for Modbus RTU communication
- Implements NLog for rotating file logs (stored in `/logs` directory)
- Asynchronous scanning with cancellation token support
- 500ms timeout per configuration test
- Tests standard Modbus function codes (01-24)
- Attempts to read from address 0 to verify device communication

## Log Files

Logs are automatically saved to:
- Location: `{ApplicationDirectory}/logs/logfile.log`
- Rotation: Daily
- Retention: 7 days

## Building

This project requires:
- Visual Studio 2022 or later
- .NET 10 SDK

## License

[Add your license information here]

## Contributing

[Add contribution guidelines here]