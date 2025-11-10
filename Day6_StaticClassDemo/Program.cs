using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_StaticClassDemo
{
    static class Multiplier
    {
        public static double pi = 3.14;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b) { return a - b; }
        public static int Multiply(int a, int b) { return a * b; }
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("demoninator should not be zero");
            }
            return a / b;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int res = Multiplier.Add(3, 5);
            Console.WriteLine(res);
            res = Multiplier.Subtract(4, 3);
            Console.WriteLine("sub" + res);
        }
    }
}
