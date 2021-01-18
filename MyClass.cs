using System.IO.Ports;

namespace MyAppCode
{
    public static class MyClass
    {
        public static string ReadFromSerialPort(ISerialPort serialPort)
        {
            if (!serialPort.IsOpen)
                serialPort.Open();

            return serialPort.ReadLine();
        }

        public static void Cast(ISerialPort serialPort)
        {
            var cast = serialPort as SerialPort;
            // Close() is not a member of ISerialPort
            cast!.Close();
        }
    }
}