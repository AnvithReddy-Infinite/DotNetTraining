using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address HomeAddress { get; set; }
        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
    internal class ShallowCopyDemo
    {

        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Name = "Anvith", Age = 21, HomeAddress = new Address { City = "Vizag", Street = "Rushikonda" } };
            Employee emp2 = emp1.ShallowCopy();

            emp2.Name = "Lucky";
            emp2.HomeAddress.City = "Karimnagar";

            Console.WriteLine("emp1.name" + emp1.Name);
            Console.WriteLine($"emp1.HomeAddress" + emp1.HomeAddress.City);

            Console.WriteLine("emp2.name" + emp2.Name);
            Console.WriteLine($"emp2.HomeAddress" + emp2.HomeAddress.City);
        }
    }
}
