using System;
using StaticExample;

namespace StaticConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int z = StaticClass.Increment();
            Console.Read();
        }
    }
}
