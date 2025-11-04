using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Student
    {
        public string Name;

        // Array to hold marks for 3 subjects
        public int[] SubjectMarks = new int[3];

        // Method to calculate total, average, and grade using out parameters
        public void CalculateResult(out int total, out double average, out string grade)
        {
            total = 0;
            for (int i = 0; i < SubjectMarks.Length; i++)
            {
                total += SubjectMarks[i];
            }
            average = total / 3.0;

            // Assign grade based on average
            if (average >= 90)
            {
                grade = "A+";
            }
            else if (average >= 80)
            {
                grade = "A";
            }
            else if (average >= 70)
            {
                grade = "B";
            }
            else if (average >= 60)
            {
                grade = "C";
            }
            else if (average >= 50)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }
        }

        public void DisplayResult()
        {
            int total;
            double average;
            string grade;

            CalculateResult(out total, out average, out grade);

            Console.WriteLine("\n Student Report");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Name    : " + Name);
            Console.WriteLine("Total Marks : " + total);
            Console.WriteLine("Average : " + average.ToString("0.00"));
            Console.WriteLine("Grade   : " + grade);
            Console.WriteLine("---------------------------");
        }
    }
}
