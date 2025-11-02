using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            string grade = "";

            if (marks >= 90)
            {
                grade = "A+";
            }
            else if (marks >= 80)
            {
                grade = "A";
            }
            else if (marks >= 70)
            {
                grade = "B";
            }
            else if (marks >= 60)
            {
                grade = "C";
            }
            else if (marks >= 50)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }

            Console.WriteLine("\nStudent Name: " + name);
            Console.WriteLine("Marks: " + marks);
            Console.WriteLine("Grade: " + grade);
            Console.ReadLine();

        }
    }
}
