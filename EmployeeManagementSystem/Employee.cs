using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public int Experience { get; set; }

        public Employee(int id, string name, string dept, double salary, int exp)
        {
            EmpId = id;
            Name = name;
            Department = dept;
            Salary = salary;
            Experience = exp;
        }
        public override string ToString()
        {
            return $"EmpId: {EmpId}, Name: {Name}, Department: {Department}, Salary: Rs: {Salary}, Experience: {Experience} yrs";
        }
    }
}
