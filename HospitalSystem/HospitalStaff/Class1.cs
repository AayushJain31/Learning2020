using System;
using System.Collections.Generic;
using System.Text;
using AccessModifiers;

namespace AccessModifiers
{
    internal class Customer : ShopKeeper
    {
        public string Name { get; set; }
        private void BankDetails()
        {

        }
        protected void PaymentDetails()
        {
            Console.WriteLine("Payment Successfull!");
        }
        public void ShowDetails()
        {
            Console.WriteLine(Name);
        }
        internal void InternalCheck()
        {

        }
    }

    public class ShopKeeper
    {
        public void Check()
        {

        }
    }

}

namespace InternalAccess
{
    public class InternalExample
    {
        Customer CM = new Customer();

        public void Verify()
        {
            CM.InternalCheck();
        }
    }

}