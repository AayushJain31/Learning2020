using System;

namespace BusinessLogic
{
    public class Blog
    {
        public string BlogName { get; set; }
        // data members 
        public string name;
        public string subject;

        // public method of base class  
        public void BlogContent(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("My Name: " + name);
            Console.WriteLine("My Blog Subject is: " + subject);
        }
    }

    public class Page : Blog // inheriting the Blog class using :  
    { 
        public Page()
        {
            Console.WriteLine("Welcome To Our Blog!");
        }
    }

    public class BlogEmployees
    {
        public ID EmployeeID { get; set; }
        public Salary EmployeeSalary { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public void WorkField()
        {

        }

    }
    public class BlogWriters //Not An Employee
    {
        public ID WriterID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class BlogReaders
    {
        public ID ReaderID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class ID
    {

    }
    public class Salary
    {
        public Salary(BlogEmployees BE)
        {
            
        }
        public BlogEmployees Employee { get; set; }
        public string SalarySlip { get; set; }
        public decimal Taxes { get; set; }
        public decimal SalaryAmount { get; set; }
    }

    public class BlogTopic
    {
        public BlogEmployees Employee { get; set; }
        public BlogTopic()
        {

        }
        public virtual string BlogContent()
        {
            return "C# Fundamentals begin with knowing IL,CLS,CTS and JIT.";
        }
    }


}
