using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignment
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int TotalMarks { get; set; }
        public char Gender { get; set; }

        // Expression-bodied ToString override
        public override string ToString()
            => $"{Name}, Class: {Class}, Total Marks: {TotalMarks}";
    }
}
