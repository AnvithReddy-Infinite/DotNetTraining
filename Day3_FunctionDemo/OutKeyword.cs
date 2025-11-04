using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class OutKeyword
    {
        static void Calculate(int a, int b, out int sum, out int diff, out int multiply)
        {
            sum = a + b;
            diff = a - b;
            multiply = a * b;
        }

        static void Main(string[] args)
        {

            Calculate(100, 40, out int sum, out int diff, out int multiply);
            Console.WriteLine($"sum = {sum} \n difference = {diff} \n Multiplication = {multiply}");
            Console.ReadLine();
        }
    }
}
