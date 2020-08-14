using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer()
            {
                ID = 1,
                Name = "ABC"
            });
            Customers.Add(new Customer()
            {
                ID = 2,
                Name = "XYZ"
            });
            Customers.Add(new Customer()
            {
                ID = 3,
                Name = "PQR"
            });
            Customers.Add(new Customer()
            {
                ID = 4,
                Name = "LMN"
            });

            List<Address> Addresses = new List<Address>();
            Addresses.Add(new Address() 
            {
                CustomerId = 1,
                Street1 = "Mumbai",
                Street2 = "Dahanu"
            });
            Addresses.Add(new Address()
            {
                CustomerId = 2,
                Street1 = "NewYork",
                Street2 = "Wall Street"
            });

            //Console.WriteLine("Hello World!");
            //var LinqJoin = (from C1 in Customers
            //                join A1 in Addresses
            //                on C1.ID equals A1.CustomerId
            //                select new
            //                {
            //                    C1.ID,
            //                    C1.Name,
            //                    A1.Street1
            //                }).ToList();

            //Console.WriteLine("Linq Join Query Result");
            //foreach (var item in LinqJoin)
            //{
            //    Console.WriteLine("ID : {0} Name : {1} Street : {2} ",item.ID,item.Name,item.Street1);
            //}

            var LinqLeftJoin = (from C2 in Customers
                                join A2 in Addresses
                                on C2.ID equals A2.CustomerId 
                                into data 
                                from A2 in data.DefaultIfEmpty()
                                select new
                                {
                                    Id = C2.ID,
                                    Name = C2.Name,
                                    Street1 = A2 != null ? A2.Street1 : "null"
                                    
                                }).ToList();

            Console.WriteLine("Linq Left Join Query Result");
            foreach (var item in LinqLeftJoin)
            {
                Console.WriteLine("ID : {0} Name : {1} Street : {2} ", item.Id, item.Name, item.Street1);
            }
            Console.Read();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Address
    {
        public int CustomerId { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
    }
}
