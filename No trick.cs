namespace Library
{
    public interface IFoo
    {
        void Bar();
    }

    public class Foo : IFoo
    {
        public void Bar()
        {
            // library implementation
        }
    }
}

namespace MyAppCode
{
    public static class UseFoo
    {
        public static void CallBar(Library.IFoo usuallyFoo)
        {
            usuallyFoo.Bar();
        }
    }
}

namespace MyTestCode
{
    class SimFoo : Library.IFoo
    {
        public void Bar()
        {
            // simulated implementation
        }
    }

    static class TestUseFoo
    {
        public static void TestCallBar()
        {
            MyAppCode.UseFoo.CallBar(new SimFoo());
        }
    }
}