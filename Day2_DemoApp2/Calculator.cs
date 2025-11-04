using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DemoApp2
{
    internal class Calculator
    {
        //public void Addition(int a, int b)
        //{
        //    Console.WriteLine($"Addition {a + b}");
        //}
        //public void Subtraction(int a, int b)
        //{
        //    Console.WriteLine($"subtraction {a - b}");
        //}
        //public void Multiplication(int a, int b)
        //{
        //    Console.WriteLine($"Multiplication {a * b}");
        //}
        //public void Division(int a, int b)
        //{
        //    Console.WriteLine($"Division {a / b}");
        //}


        //// method with return and with Args
        //public int Addition(int a, int b)
        //{
        //    int sum = a + b;
        //    int difference = a - b;
        //    return sum;
        //}
        //public void Subtraction(int a, int b)
        //{
        //    Console.WriteLine("Difference = " + (a - b));

        public void Calculate(int num1, int num2, out int addResult, out int diff, out int productResult, out int divisionResult)
        {
            addResult = num1 + num2;
            diff = num1 - num2;
            productResult = num1 * num2;
            divisionResult = num1 / num2;
        }

    }
    }

