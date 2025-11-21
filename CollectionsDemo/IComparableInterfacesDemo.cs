using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class InfiniteEmployee : IComparable<InfiniteEmployee>
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public int CompareTo(InfiniteEmployee other)
        {
            return this.Empid.CompareTo(other.Empid);
        }
    }
    internal class Icomparable
    {
        static void Main(string[] args)
        {
            List<InfiniteEmployee> infiniteEmployees = new List<InfiniteEmployee>();
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807024, Name = "Keerthick ragul", Salary = 9000, Age = 21, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807025, Name = "Waseef Tauqueer", Salary = 1129000, Age = 20, Location = "Bangalore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807006, Name = "Manikanta sai", Salary = 50000, Age = 24, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807029, Name = "Logeshwaran V", Salary = 50000, Location = "Bangalore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807007, Name = "Hyma", Salary = 21000, Age = 22, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 851, Name = "Monika", Salary = 18000, Age = 21, Location = "Vizag" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807028, Name = "Keerthana", Salary = 50000, Age = 20, Location = "Bangalore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807004, Name = "keerthi", Salary = 21000, Age = 22, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807000, Name = "R Syeda Mehraj Fatima", Salary = 21000, Age = 23, Location = "Banglore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807014, Name = "Mani", Salary = 20000, Age = 26, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807002, Name = "Pooja", Salary = 21000, Age = 23, Location = "Bangalore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807002, Name = "Usha sri", Salary = 21000, Age = 22, Location = "Vizag" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807002, Name = "Anvith", Salary = 21000, Age = 23, Location = "Vizag" });
            Console.WriteLine("employee details");
            foreach (var emp in infiniteEmployees)
            {
                Console.WriteLine($"Empid :{emp.Empid},Name:{emp.Name},Salary:{emp.Salary},Age:{emp.Age},Location:{emp.Location}");
            }
            infiniteEmployees.Sort();
            Console.WriteLine("\n Employee Details after sorting the salary");
            foreach (var emp in infiniteEmployees)
            {
                Console.WriteLine($"Empid :{emp.Empid},Name:{emp.Name},Salary:{emp.Salary},Age:{emp.Age},Location:{emp.Location}");
            }
        }
    }
}

