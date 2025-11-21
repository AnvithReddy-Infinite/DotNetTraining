using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and fill employee list
            List<Employee> employeesList = new List<Employee>
            {
                new Employee(101, "Rudra", "IT", 60000, 7),
                new Employee(102, "Keshava", "HR", 48000, 4),
                new Employee(103, "Arjun Reddy", "Finance", 65000, 9),
                new Employee(104, "Virat Kohli", "IT", 72000, 6),
                new Employee(105, "Rama", "Sales", 40000, 3),
                new Employee(106, "Krishna", "IT", 52000, 5),
                new Employee(107, "Advaith Bhaskar", "HR", 55000, 12),
                new Employee(108, "Narasimha", "Finance", 58000, 2),
                new Employee(109, "Madhava", "Sales", 35000, 1),
                new Employee(110, "Shiva", "IT", 80000, 11),
            };

            Console.WriteLine("=== All Employees ===");
            foreach (var emp in employeesList)
                Console.WriteLine(emp);

            // Lambda Filtering & Searching
            Console.WriteLine("\n=== Employees with Salary > 50,000 ===");
            var highSalary = employeesList.Where(emp => emp.Salary > 50000);
            foreach (var emp in highSalary)
                Console.WriteLine(emp);

            Console.WriteLine("\n=== Employees from IT Department ===");
            var itEmployees = employeesList.Where(emp => emp.Department == "IT");
            foreach (var emp in itEmployees)
                Console.WriteLine(emp);

            Console.WriteLine("\n=== Experience > 5 Years ===");
            var experienced = employeesList.Where(emp => emp.Experience > 5);
            foreach (var emp in experienced)
                Console.WriteLine(emp);

            Console.WriteLine("\n=== Employees Whose Name Starts with 'A' ===");
            var startsWithA = employeesList.Where(emp => emp.Name.StartsWith("A"));
            foreach (var emp in startsWithA)
                Console.WriteLine(emp);

            // Sorting & Ordering
            Console.WriteLine("\n=== Sorted by Name (A-Z) ===");
            var byName = employeesList.OrderBy(emp => emp.Name);
            foreach (var emp in byName)
                Console.WriteLine(emp);

            Console.WriteLine("\n=== Sorted by Salary (High to Low) ===");
            var bySalary = employeesList.OrderByDescending(emp => emp.Salary);
            foreach (var emp in bySalary)
                Console.WriteLine(emp);

            Console.WriteLine("\n=== Sorted by Experience (Low to High) ===");
            var byExperience = employeesList.OrderBy(emp => emp.Experience);
            foreach (var emp in byExperience)
                Console.WriteLine(emp);

            // Promotion list sample: Employees with >5 yrs in IT or >8 in any department
            Console.WriteLine("\n=== Promotion List (Custom) ===");
            var promotionList = employeesList.Where(emp => (emp.Department == "IT" && emp.Experience > 5) || emp.Experience > 8);
            foreach (var emp in promotionList)
                Console.WriteLine(emp);
        }
    }
}
