using System.IO.Ports;

namespace MyAppCode
{
    public interface ISerialPort
    {
        /// <inheritdoc cref="SerialPort.IsOpen"/>
        bool IsOpen { get; }

        /// <inheritdoc cref="SerialPort.Open"/>
        void Open();

        /// <inheritdoc cref="SerialPort.ReadLine"/>
        string ReadLine();
    }
}