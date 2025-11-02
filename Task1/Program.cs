using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your base salary: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your years of service: ");
            int yearsOfService = Convert.ToInt32(Console.ReadLine());

            double bonusPercentage = 0;

            if (yearsOfService > 10)
            {
                bonusPercentage = 20; 
            }
            else if (yearsOfService >= 5)
            {
                bonusPercentage = 10; 
            }
            else
            {
                bonusPercentage = 5; 
            }

            double bonusAmount = baseSalary * bonusPercentage / 100;

            double finalSalary = baseSalary + bonusAmount;

            Console.WriteLine("Bonus Percentage: " + bonusPercentage + "%");
            Console.WriteLine("Bonus Amount: Rs" + bonusAmount);
            Console.WriteLine("Final Salary after bonus: Rs" + finalSalary);
            Console.ReadLine();

        }
    }
}

