using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public class LspDemo
    {
        // LSP: Liskov Substitution Principle
        public static void Main()
        {
            EmployeeBase permEmp = new PermanentEmployee();
            EmployeeBase genericEmp = new RegularEmployee();

            Console.WriteLine("Permanent Employee Bonus: " + permEmp.GetBonus(10000));
            Console.WriteLine("Regular Employee Bonus: " + genericEmp.GetBonus(10000));

            IContractEmployee contractEmp = new ContractEmployee();
            Console.WriteLine("Contract Employee Hourly Pay: " + contractEmp.CalculateHourlyRate(160, 50000));
        }
    }

   
    public abstract class EmployeeBase
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDept { get; set; }

        public abstract decimal GetBonus(decimal salary);
    }

    public class PermanentEmployee : EmployeeBase
    {
        public override decimal GetBonus(decimal salary)
        {
            return salary * 0.20m;
        }
    }

    public class RegularEmployee : EmployeeBase
    {
        public override decimal GetBonus(decimal salary)
        {
            return salary * 0.10m;
        }
    }

  
    public interface IContractEmployee
    {
        decimal CalculateHourlyRate(int hours, decimal salary);
    }

    public class ContractEmployee : IContractEmployee
    {
        public decimal CalculateHourlyRate(int hours, decimal salary)
        {
            return salary / hours;
        }
    }
}
