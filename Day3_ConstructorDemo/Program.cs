using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dep = new Department();
            //we will get nefault values .
            dep.DisplayDepartmentInfo();
            //dep.getDepartmentInfo();
            //dep.DisplayDepartmentInfo();
            Department dep1 = new Department(201, "MR", "vizag");
            dep1.DisplayDepartmentInfo();
            Department dep2 = new Department(102, "hr", "chennai");
            Department dep3 = new Department(dep2);
            dep3.DisplayDepartmentInfo();
            Console.ReadLine();
        }
    }
}
