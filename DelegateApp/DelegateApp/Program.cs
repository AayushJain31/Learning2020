using System;


namespace DelegateApp
{
    class Program
    {
        delegate int NumberChange(int n);
        delegate void PointToFun(); //Delegate Declaration
        static PointToFun p; //Instance

        static int num = 10;
        public static int AddNum(int P)
        {
            num += P;
            return num;
        }
        public static int MultNum(int Q)
        {
            num *= Q;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
        static void Main(string[] args)
        {

            NumberChange NC1 = new NumberChange(AddNum);
            NumberChange NC2 = new NumberChange(MultNum);
            NC1(25);
            Console.WriteLine("Value of Num : {0} ", GetNum());
            NC2(5);
            Console.WriteLine("Value of Num : {0} ", GetNum());
            p += Fun1;
            p += Fun2;
            p.Invoke();
            Console.Read();
        }
        static void Fun1()
        {
            Console.WriteLine("Fun1");
        }
        static void Fun2()
        {
            Console.WriteLine("Fun2");
        }
    }
}
