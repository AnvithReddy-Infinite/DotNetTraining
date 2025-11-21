using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assignment
{
    public static class IntExtensions
    {
        public static int SumOfSquares(this IEnumerable<int> nums)
        {
            int sum = 0;
            foreach (int n in nums)
            {
                sum += n * n;
            }
            return sum;
        }
    }
}
