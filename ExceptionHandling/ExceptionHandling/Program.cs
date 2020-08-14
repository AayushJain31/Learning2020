using System;

namespace ExceptionHandling
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double a = 7.0, b = 0;
    //        double c;
    //        try
    //        {
    //            c = a / b;
    //        }
    //        catch(DivideByZeroException D)
    //        { 
    //            Console.WriteLine("Division By Zero Not Allowed : {0} " , D.Message);
    //            Console.Read();
    //        }       
    //    }
    //}

    class DivByZero : Exception
    {
        public DivByZero()
        {
            Console.Write("Exception Has Occurred : Do Not Divide By Zero! ");
        }
    }

    class Program
    { 
        public double DivisionOperation(double n , double d)
        {
            if (d == 0)
            {
                throw new DivByZero(); //Throw Custom/User made Exception
            } 
            return n / d;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            double num = 9, den = 0, quotient;
            try
            { 
                quotient = obj.DivisionOperation(num, den);
                Console.WriteLine("Quotient = {0}", quotient);
            } 
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
                //Console.Read();
            }
            finally
            {
                Console.WriteLine("Finally This Happens!!!");
                Console.Read();
            }
            Console.WriteLine("Hello!!!"); //Code After Finally Can Execute
        }
    }

}

