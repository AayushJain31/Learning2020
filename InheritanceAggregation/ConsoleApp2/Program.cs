using System;
using BusinessLogic;
using BlogInfo;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogEmployees BE = new BlogEmployees();
            BE.EmployeeName = "";
            BE.WorkField();

            Salary SLR = new Salary(BE);

            Page BlogPage = new Page();
            BlogPage.BlogContent("Aayush Jain", "C# Fundamentals");
             
            Console.Read();
        }
    }
}
