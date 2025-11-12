using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
    internal class OperatorOverloadingDemo
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(12, 30);
            Complex b = new Complex(4, 5);
            Complex sum = a + b;
            Complex sub = a - b;
            Complex mul = a * b;
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);

            Console.WriteLine($"a == b :{a == b}");
            Console.WriteLine($"a != b : {a != b}");

            Console.ReadLine();
        }
    }
    public class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
        private string lastOperator = " ";
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            Complex result = new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
            result.lastOperator = "+ (Addition)";
            return result;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex result = new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
            result.lastOperator = "- (Subtraction)";
            return result;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex result = new Complex(a.Real * b.Real, a.Imaginary * b.Imaginary);
            result.lastOperator = "* (Multiplication)";
            return result;
        }
        public override string ToString()
        {
            return $"Operation: {lastOperator} -> Result={Real} +{Imaginary}i";
        }
    }
}

