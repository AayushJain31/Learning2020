using System;
using System.Collections.Generic;
using System.Drawing;
namespace Gen0_1_2PerfMon
{
    class Program
    {
        public static List<Customer> x1 = new List<Customer>();
        static void Main(string[] args)
        {
            Console.WriteLine("Blast it ");
            Console.Read();
            Console.WriteLine("Started ");
            for (int i = 0; i < 100000000; i++)
            {
                //Customer x = new Customer();
                //x.Name = DateTime.Now.ToString();
                //x1.Add(x);
                ////Thread.Sleep(500);
                SolidBrush redBrush = new SolidBrush(Color.Red);
            }

            Console.Read();
        }
    }
    public class Customer
    {
        public string Name;
    }
}
