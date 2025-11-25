namespace Test_25_Nov
{
    // Use classic setters instead of init-only so older compilers work
    public class EmployeeRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public bool IsVeteran { get; set; }

        // simple constructor to ensure defaults
        public EmployeeRecord()
        {
            Name = string.Empty;
            Role = string.Empty;
            IsVeteran = false;
        }
    }
}
