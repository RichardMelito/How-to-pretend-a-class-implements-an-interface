using System;

namespace MyTestCode
{
    public class SimSerialPort : MyAppCode.ISerialPort
    {
        public bool IsOpen { get; private set; } = false;

        public void Open() => IsOpen = true;

        public string ReadLine()
        {
            if (!IsOpen)
                throw new InvalidOperationException();

            return "Hello simulated world!";
        }
    }

    static class TestMyClass
    {
        public static void TestReadFromSerialPort()
        {
            MyAppCode.MyClass.ReadFromSerialPort(new SimSerialPort());
        }
    }
}