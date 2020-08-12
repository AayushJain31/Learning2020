using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task t1 = new Task(fun1);
            Task t2 = new Task(fun2);
            t1.Start();
            t2.Start();
            Console.Read();
        }
        static void fun1()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Fun1");
        }
        static void fun2()
        {
            Console.WriteLine("Fun2");
        }
    }
}
