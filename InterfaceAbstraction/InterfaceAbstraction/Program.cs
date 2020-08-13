using System;
using InterfaceAbstractClass;
using static InterfaceAbstractClass.Class1;

namespace InterfaceAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            IInterface II = new ConcreteClass();
            II.FunctionA();
            II.FunctionB();
            II.FunctionC();
            Console.Read();
            Console.WriteLine("Hello World!");
        }
    }
}
