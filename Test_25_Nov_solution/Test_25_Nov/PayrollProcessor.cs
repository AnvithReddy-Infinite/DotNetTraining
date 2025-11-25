using System;
using System.Collections.Generic;

namespace Test_25_Nov
{
    public class PayrollProcessor
    {
        private readonly IEmployeeDataReader _dataReader;

        // Use explicit Dictionary constructor with classic initializers
        private static readonly Dictionary<int, decimal> BaseSalaries = new Dictionary<int, decimal>
        {
            { 101, 65000m },
            { 102, 120000m },
            { 103, 20000m },
            { 104, 90000m },
            { 105, 75000m },
            { 106, 88000m },
        };

        public PayrollProcessor(IEmployeeDataReader dataReader)
        {
            if (dataReader == null) throw new ArgumentNullException(nameof(dataReader));
            _dataReader = dataReader;
        }

        // expression-bodied is okay for older compilers, but keep simple method to be safe
        private decimal GetBaseSalary(int employeeId)
        {
            decimal sal;
            return BaseSalaries.TryGetValue(employeeId, out sal) ? sal : 0m;
        }

        // Use classic if/else pattern matching replacement so older language works
        public decimal CalculateTotalCompensation(int employeeId)
        {
            var record = _dataReader.GetEmployeeRecord(employeeId);
            decimal bonus = 0m;

            if (record != null)
            {
                if (record.Role == "Manager")
                {
                    bonus = record.IsVeteran ? 10000m : 5000m;
                }
                else if (record.Role == "Developer")
                {
                    bonus = 2000m;
                }
                else if (record.Role == "Intern")
                {
                    bonus = 500m;
                }
                else
                {
                    bonus = 0m;
                }
            }

            var baseSalary = GetBaseSalary(employeeId);
            return baseSalary + bonus;
        }
    }
}
