using System.IO.Ports;
using NModbus.IO;

namespace mobbus_rtu_scaner
{
    public class SerialPortAdapter : IStreamResource
    {
        private readonly SerialPort serialPort;

        public SerialPortAdapter(SerialPort serialPort)
        {
            this.serialPort = serialPort ?? throw new ArgumentNullException(nameof(serialPort));
        }

        public Stream Stream => serialPort.BaseStream;

        public int InfiniteTimeout => SerialPort.InfiniteTimeout;

        public int ReadTimeout
        {
            get => serialPort.ReadTimeout;
            set => serialPort.ReadTimeout = value;
        }

        public int WriteTimeout
        {
            get => serialPort.WriteTimeout;
            set => serialPort.WriteTimeout = value;
        }

        public void DiscardInBuffer()
        {
            serialPort.DiscardInBuffer();
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return serialPort.BaseStream.Read(buffer, offset, count);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            serialPort.BaseStream.Write(buffer, offset, count);
        }

        public void Dispose()
        {
            serialPort?.Dispose();
        }
    }
}
