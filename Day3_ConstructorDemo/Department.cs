using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_ConstructorDemo
{
    internal class Department
    {
        int departmentId;
        string departmentName, depLocation;
        //default constructor or parameterless constructor.
        //constructor is a special method inside a class that is automatically called when an object is called.
        //used for initializing object variables
        //className and constructor anme is same..
        //constructor overloading
        //static constructor
        static Department()
        {
            Console.WriteLine("static constructor");
        }
        public Department()
        {
            departmentId = 101;
            departmentName = "Unknown";
            depLocation = "Unknown";
        }
        //PARAMETERIZED CONSTRUCTOR
        public Department(int id, string name, string location)
        {
            this.departmentId = id;
            this.departmentName = name;
            this.depLocation = location;
        }
        //copy constructor.
        public Department(Department dept)
        {
            this.departmentId = dept.departmentId;
            this.departmentName = dept.departmentName;
            this.depLocation = dept.depLocation;
        }
        public void getDepartmentInfo()
        {
            Console.WriteLine("enter the department Id");
            departmentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name of the department");
            departmentName = Console.ReadLine();
            Console.WriteLine("enter the department location");
            depLocation = Console.ReadLine();

        }
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine("Department Details");
            Console.WriteLine("ID " + departmentId);
            Console.WriteLine("department" + departmentName);
            Console.WriteLine("department location" + depLocation);
        }
    }
}
