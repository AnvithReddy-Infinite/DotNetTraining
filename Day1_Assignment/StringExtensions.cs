using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assignment
{
    public static class StringExtensions
    {
        public static bool IsUpper(this string str)
        {
            return str != null && str == str.ToUpper();
        }
    }
}
