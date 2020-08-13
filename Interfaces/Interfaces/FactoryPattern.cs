using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IStudent
    {
        int Pay();
    }
    public class Fees : IStudent
    {
        public int Pay()
        {
            return 10000;
        }
    }

    public class Fine : IStudent
    {
        public int Pay()
        {
            return 100;
        }
    }
    public static class FactoryPattern
    {
        public static IStudent Create(int i)
        {
            if(i==0)
            {
                return new Fees();
            }
            else
            {
                return new Fine();
            }
        }
    }
}
