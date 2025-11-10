using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_IndexerDemo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
    }
    internal class EmployeeList_IndexerDemo
    {
        List<Employee> employeelist = new List<Employee>()
        {
            new Employee(){EmployeeId=1,EmployeeName="Gaddam",Gender="Male"},
            new Employee(){EmployeeId=2,EmployeeName="Lucky",Gender="Male" },
            new Employee(){EmployeeId=3,EmployeeName="Anvith",Gender="Male" }
        };
        public string this[int empid]
        {
            get
            {
                return employeelist.FirstOrDefault(e => e.EmployeeId == empid)?.EmployeeName;
            }
            set
            {
                employeelist.FirstOrDefault(e => e.EmployeeId == empid).EmployeeName = value;
            }
        }
    }
}
