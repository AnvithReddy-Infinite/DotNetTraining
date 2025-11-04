using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class FunctionWithReturnWithArgument
    {
        static int addition(int x, int y)
        {
            int res;
            res = x + y;
            return res;
        }
        static void Main()
        {
            int x, y;
            Console.WriteLine(" Enter the value for a and b");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            int result = addition(x, y);
            Console.WriteLine(" given vales summation are " + result);
            Console.ReadLine();

        }
    }
}
