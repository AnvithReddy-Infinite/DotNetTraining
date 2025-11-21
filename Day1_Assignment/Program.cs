using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1: Partial Class (Student_Part1.cs and Student_Part2.cs)
            Student s = new Student();
            s.Name = "Anvith Reddy";
            s.Age = 21;
            s.DisplayDetails();


            // Assignment 2: Extension Method (StringExtensions.cs)
            string sample = "ANVITH";
            WriteLine($"IsUpper: {sample.IsUpper()}"); 

            sample = "reddy";
            WriteLine($"IsUpper: {sample.IsUpper()}"); 


            // Assignment 4: Extension Method for SumOfSquares (IntExtensions.cs)
            List<int> nums = new List<int> { 2, 3, 4 };
            WriteLine($"Sum of Squares: {nums.SumOfSquares()}"); 
        }
    }
}
