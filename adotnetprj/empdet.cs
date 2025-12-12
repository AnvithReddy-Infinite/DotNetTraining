using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adotnetprj
{
    public class empdet
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfJoin { get; set; }
        public int DeptId { get; set; }
    }

    public class dept
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
}
