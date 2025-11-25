using System.Collections.Generic;

namespace Test_25_Nov
{
    public class MockEmployeeDataReader : IEmployeeDataReader
    {
        // Avoid new() target-typed and index initializers.
        private static readonly Dictionary<int, EmployeeRecord> _mock = new Dictionary<int, EmployeeRecord>
        {
            { 101, new EmployeeRecord { Id = 101, Name = "Sandeep Reddy", Role = "Developer", IsVeteran = false } },
            { 102, new EmployeeRecord { Id = 102, Name = "Kabir Singh", Role = "Manager", IsVeteran = true } },
            { 103, new EmployeeRecord { Id = 103, Name = "RanVijay Singh", Role = "Intern", IsVeteran = false } },
            { 104, new EmployeeRecord { Id = 104, Name = "Arjun Reddy", Role = "Manager", IsVeteran = false } },
            { 105, new EmployeeRecord { Id = 105, Name = "Anvith Reddy", Role = "Developer", IsVeteran = true } },
            { 106, new EmployeeRecord { Id = 106, Name = "Sateesh Reddy", Role = "Intern", IsVeteran = false } },

        };

        public EmployeeRecord GetEmployeeRecord(int employeeId)
        {
            EmployeeRecord rec;
            if (_mock.TryGetValue(employeeId, out rec))
                return rec;

            return new EmployeeRecord
            {
                Id = employeeId,
                Name = "Unknown",
                Role = "Contractor",
                IsVeteran = false
            };
        }
    }
}
