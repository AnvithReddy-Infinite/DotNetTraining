using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_IndexerDemo
{
    class StudentMarks
    {
        private int[] marks = new int[5];
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine("Invalid Index! Returning -1");
                    return -1;
                }
                return marks[index];
            }
            set
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine("Invalid Index! Cannot set value");
                }
                else
                {
                    marks[index] = value;
                }
            }
        }
        public void DisplayMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {marks[i]}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                StudentMarks studentMarks = new StudentMarks();
                //Setting marks using indexer
                studentMarks[0] = 85;
                studentMarks[1] = 90;
                studentMarks[2] = 75;
                studentMarks[3] = 95;
                studentMarks[4] = 98;

                //Attempting to set an invalid index
                studentMarks[5] = 100; //should display an error message

                //Getting marks using indexer
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Marks of Student {i + 1}: {studentMarks[i]}");
                }
                //Attempting to get an invalid index
                Console.WriteLine($"Marks of student 6: {studentMarks[5]}"); //should display an error message

                //Display all marks
                studentMarks.DisplayMarks();

                EmployeeList_IndexerDemo employee = new EmployeeList_IndexerDemo();
                Console.WriteLine($"employee[0]: {employee[2]}");
                Console.ReadLine();

            }
        }
    }
}