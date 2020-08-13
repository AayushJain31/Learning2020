using System;

namespace StaticExample
{
    public static class StaticClass
    {
        public static int counter = 0;
        public static int Increment()
        {
            return counter++;
        }

    }
    public class ExampleStatic
    {
        int x = StaticClass.Increment();
        static int y = 3;
    }

}
