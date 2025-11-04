using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class Static_NonStatic_Function_Demo
    {
        static int x;
        int y;
        void NonStaticMethod()
        {
            Console.WriteLine("Non Static Function");
        }
        static void StaticMethod()
        {
            Console.WriteLine("Static Function");
        }
        static void Main(string[] args)
        {
            x = 900;
            Static_NonStatic_Function_Demo staticobj = new Static_NonStatic_Function_Demo();
            staticobj.y = 200;

            Console.WriteLine(" Static Variable accessing without object" + x);
            Console.WriteLine("Non static variable accessing through object" + staticobj.y);
            StaticMethod();
            staticobj.NonStaticMethod();
            Console.ReadLine();
        }
    }
}
