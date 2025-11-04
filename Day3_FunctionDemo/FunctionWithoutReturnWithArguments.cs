using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class FunctionWithoutReturnWithArguments
    {
        static void addition(int x, int y)
        {
            int res;
            res = x + y;
            Console.WriteLine(" X+ y = " + res);
        }
        static void Main()
        {
            addition(34, 89);
            //another method to call the function -Addition
            int a, b;
            Console.WriteLine(" Enter the value for a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            addition(a, b);
            Console.ReadLine();
        }
    }
}
