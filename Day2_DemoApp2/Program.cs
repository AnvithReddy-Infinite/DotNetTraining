using Day2_DemoApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DemoApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int num1, num2;
            //Calculator calculator = new Calculator();
            //Console.WriteLine("Enter the number 1");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //calculator.Addition(num1, num2);
            //calculator.Subtraction(num1, num2);
            //calculator.Multiplication(num1, num2);
            //calculator.Division(num1, num2);

            //Employee employee = new Employee();
            //int empId;
            //string empName;
            //string designation;
            //Console.WriteLine("Enter the EmployeeId,name,Designation");
            //empId = Convert.ToInt32(Console.ReadLine());
            //empName = Console.ReadLine();
            //designation = Console.ReadLine();
            //employee.AcceptEmployeeDetails(empId, empName, designation);
            //employee.DisplayEmployeeDetails();
            //Console.ReadLine();


            Calculator calculator = new Calculator();
            calculator.Calculate(20, 10, out int addResult, out int difference, out int productResult, out int divisionResult);
            Console.WriteLine($"addidition is {addResult} and diiference is {difference} and product is {productResult} and division is {divisionResult}");
            Console.ReadLine();
        }
    }
}


//Employee employee = new Employee();

//employee.AcceptEmployeeDetails(101, "Krishna", "Software Engineer");
//employee.DisplayEmployeeDetails();

//Employee employee2 = new Employee();
//employee2.AcceptEmployeeDetails(102, "Nikhil", "QA Engineer");
//employee2.DisplayEmployeeDetails();