using Interfaces;
using System;

namespace DLLReference
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudent S =FactoryPattern.Create(0);
            int x = S.Pay();
            Console.WriteLine("Student has paid the Fees Amount : " + x);

            S = FactoryPattern.Create(1);
            int y = S.Pay();
            Console.WriteLine("Student has paid the Fine Amount : " + y);

            Console.Read();
        }
    }
}
