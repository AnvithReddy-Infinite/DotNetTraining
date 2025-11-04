using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Student Marks Evaluation System =====");
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Create array to hold student objects
            Student[] students = new Student[n];

            // Input details for each student
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for Student #{i + 1}");

                students[i] = new Student();

                Console.Write("Enter Student Name: ");
                students[i].Name = Console.ReadLine();

                // Input marks for 3 subjects
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter marks for Subject {j + 1}: ");
                    students[i].SubjectMarks[j] = Convert.ToInt32(Console.ReadLine());
                }

                // Show student report immediately or after loop - here, after each input
                students[i].DisplayResult();
                }
            }
    }
}
