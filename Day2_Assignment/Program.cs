using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day2_Assignment
{

    class Program
    {

        //public static void WriteLine(string msg)
        //{
        //    WriteLine(msg); // abstraction layer for output
        //}

        // Dictionary with initializer (id => Student object)
        static Dictionary<int, Student> students = new Dictionary<int, Student>
        {
            [1] = new Student { Name = "Amit", Class = "10th", TotalMarks = 550, Gender = 'M' },
            [2] = new Student { Name = "Neha", Class = "9th", TotalMarks = 420, Gender = 'F' },
            [3] = new Student { Name = "Arjun", Class = "11th", TotalMarks = 490, Gender = 'M' },
            [4] = new Student { Name = "Sneha", Class = "12th", TotalMarks = 310, Gender = 'F' }
        };

        // Show all students
        public static void ShowAllStudents()
        {
            WriteLine("All Students:");
            foreach (var kv in students)
            {
                WriteLine($"ID {kv.Key}: {kv.Value}");
            }
        }

        // GetStudentAsync as required
        public static async Task<Student> GetStudentAsync(int id)
        {
            try
            {
                Student res = null;
                // If id is not provided or not found, return default
                if (!students.TryGetValue(id, out res) || id == 0)
                {
                    WriteLine("No ID provided, showing default student details...");
                    res = new Student { Name = "Default", Class = "Unknown", TotalMarks = 500, Gender = 'M' };
                }
                if (res.TotalMarks < 300)
                    throw new Exception("Total marks less than 500");

                return res;
            }
            catch (Exception ex) when (ex.Message.Contains("less than 500"))
            {
                await Task.Delay(100); // uses 'await' in catch as asked
                WriteLine("Student has insufficient marks (below 500), please verify!");
                return null;
            }
        }

        static async Task Main(string[] args)
        {
            try
            {
                ShowAllStudents();

                // Test by fetching IDs (change or loop for more tests)
                Student s1 = await GetStudentAsync(2); // Should work normally
                if (s1 != null) WriteLine($"Search result: {s1}");

                Student s2 = await GetStudentAsync(4); // Marks < 500 triggers catch
                if (s2 != null) WriteLine($"Search result: {s2}");

                Student s3 = await GetStudentAsync(0); // Returns default
                if (s3 != null) WriteLine($"Search result: {s3}");
            }
            catch (Exception e)
            {
                WriteLine("Error: " + e.Message);
            }
        }
    }
}
