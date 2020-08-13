using System;
using System.Collections.Generic;

namespace GenericsAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericExample<int> GE = new GenericExample<int>();
            bool a = GE.Check(18, 36);
            Console.WriteLine(a);

            GenericExample<string> GE1 = new GenericExample<string>();
            bool b = GE1.Check("C#", ".NET");
            Console.WriteLine(b);

            Customer C = new Customer();
            C.Name = "XYZ";

            Dictionary<string, Customer> dict = new Dictionary<string, Customer>();
            dict.Add(C.Name, C);
            var FindCustomer = dict["XYZ"];
            Console.WriteLine(FindCustomer);

            Stack<int> S = new Stack<int>();
            S.Push(1);
            S.Push(2);
            S.Push(3);
            Console.WriteLine("Stack Content : ");
            foreach (int item in S)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Item Removed From Stack : " + S.Pop());

            Console.Read();
        }
    }
    public class GenericExample<T>
    {
        public bool Check(T val1 , T val2)
        {
            if (val1.Equals(val2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Customer
    {
        //Stack<int> S = new Stack<int>();

        //Queue<string> Q = new Queue<string>();

        public string Name;
    }
}
