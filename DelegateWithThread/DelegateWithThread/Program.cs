using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateWithThread
{
    class Program
    {
        static FileParser P = new FileParser();
        static void Main(string[] args)
        {
            
            P.ParserPointer += Display;
            P.ParserPointer += Display1;
            Task T = new Task(P.Parse);
            T.Start();
            //Parallel.For(0, 1000000, x => OneMillionIterations());
            //Console.WriteLine("This is Main");
            Console.Read();
        }
        static void OneMillionIterations()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x = x + "s";
            }
        }
        static void Display(int i)
        {
            Console.WriteLine("Fisrt : " + i);
        }
        static void Display1(int i)
        {
            Console.WriteLine("Second : " + i);
        }
    }

    public class FileParser
    {
        public delegate void ParsePoint(int i);
        public event ParsePoint ParserPointer;
        public void Parse()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(2000);
                ParserPointer.Invoke(i);
            }
        }
    }
}
