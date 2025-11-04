using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class FunctionWithReturnWithoutArgs
    {
        static void Main(string[] args)
        {
            Addition();
            Console.ReadLine();
}
        static void Addition()
        {
            int num1, num2, sum;
            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Sum of given numbers: " + sum);
        }
    }
}
