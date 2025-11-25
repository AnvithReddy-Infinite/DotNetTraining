using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_24_Nov
{
    internal class Assignment
    {
        public class Calculator
        {
            public int Square(int a) => a * a;
        }
        public class StringHelper
        {
            public string ToUpper(string input) => input.ToUpper();
        }
        public class MathHelper
        {
            public int Multiply(int a, int b) => a * b;
        }
        public class StudentService
        {
            public void ValidateAge(int age)
            {
                if (age < 0)
                    throw new ArgumentException("Invalid age");
            }
        }
        public class NumberService
        {
            public List<int> GetEvenNumbers()
            {
                return new List<int> { 2, 4, 6, 8 };
            }
        }
        public class MarkService
        {
            public async Task<int> GetMarksAsync()
            {
                await Task.Delay(100);
                return 90;
            }
        }
        public class MarksSource
        {
            public static IEnumerable<int> Marks()
            {
                return new List<int> { 45, 60, 75, 90 };
            }
        }

    }
}