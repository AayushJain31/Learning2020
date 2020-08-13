using System;
using System.Net.NetworkInformation;

namespace InterfaceAbstraction
{
    public class Class1
    {
        public interface IInterface
        {
            void FunctionA();
            void FunctionB();
            void FunctionC();
        }

        public abstract class AbstractClass : IInterface
        {
            public void FunctionA()
            {
                Console.WriteLine("FunctionA() implemented in abstract class. Cannot be overridden in concrete class.");
            }

            public virtual void FunctionB()
            {
                Console.WriteLine("FunctionB() implemented in abstract class. Can be overridden in concrete class.");
            }

            public abstract void FunctionC();
        }

        public class ConcreteClass : AbstractClass, IInterface
        {
            public override void FunctionB()
            {
                base.FunctionB();
                Console.WriteLine("FunctionB() implemented in abstract class but optionally overridden in concrete class.");
            }

            public override void FunctionC()
            {
                Console.WriteLine("FunctionC() must be implemented in concrete class because abstract class provides no implementation.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                IInterface II = new ConcreteClass();
                II.FunctionA();
                II.FunctionB();
                II.FunctionC();

            }


        }

    }
}




