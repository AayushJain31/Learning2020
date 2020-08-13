using System;
using System.Diagnostics;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch S = new Stopwatch();
            S.Start();
            Check();
            S.Stop();
            Console.WriteLine(S.ElapsedMilliseconds);
            S.Start();
            Check();
            S.Stop();
            Console.WriteLine(S.ElapsedMilliseconds);
            S.Start();
            Check();
            S.Stop();
            Console.WriteLine(S.ElapsedMilliseconds); //Performance Degrades as Computations Increase
            Console.Read();
        }
        static void Check()
        {
            for(int i = 0; i < 1000000; i++)
            {
                int num = 21;
                object obj = num; //Boxing
                int x = (int)obj; //unboxing
            }
        }
    }
}
