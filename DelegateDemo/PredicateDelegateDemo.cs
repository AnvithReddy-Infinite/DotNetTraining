using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Experience { get; set; }
    }
    internal class PredicateDelegateDemo
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { EmpId = 1, Name = "John", Experience = "5 years" },
                new Employee { EmpId = 2, Name = "Jane", Experience = "3 years" },
                new Employee { EmpId = 3, Name = "Doe", Experience = "8 years" }
            };
            Predicate<Employee> isExperienced = emp => emp.Experience.Contains("5");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Employee ID: {emp.EmpId}, Name: {emp.Name}, Experience: {emp.Experience}");
                if (isExperienced(emp))
                {
                    Console.WriteLine($"Experienced Employee: {emp.Name}");
                }
            }

        }




        Predicate<int> isEven = delegate (int number)
        {
            return number % 2 == 0;
        };
    }
}
