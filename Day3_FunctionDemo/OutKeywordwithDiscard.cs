using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class OutKeywordwithDiscard
    {
        static void Main(String[] args)
        {
            Calculate(10, 5, out int sum, out _, out int product);
            Console.WriteLine("sum:" + sum);
            Console.WriteLine("Product:" + product);
        }
        static void Calculate(int a, int b, out int sum, out int diff, out int product)
        {
            sum = a + b;
            diff = a - b;
            product = a * b;
        }
    }
}
