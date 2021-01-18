using System.IO.Ports;

namespace MyAppCode
{
    class CompositionSerialPort : ISerialPort
    {
        readonly SerialPort _serialPort = new();

        public bool IsOpen => _serialPort.IsOpen;

        public void Open() => _serialPort.Open();

        public string ReadLine() => _serialPort.ReadLine();
    }
}
