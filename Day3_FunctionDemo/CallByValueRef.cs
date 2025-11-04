using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class CallByValueRef
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = 20;
            Console.WriteLine("calling by value ");
            Console.WriteLine("value of A before calling MethodValue" + a);//10
            MethodValue(a);//20
            Console.WriteLine("After calling MethodMethod A value" + a);//10
            Console.WriteLine("calling by reference ");
            Console.WriteLine("value of B before calling Methodref" + b);//20
            MethodRef(ref b);//40
            Console.WriteLine("After calling MethodVref B value" + b);//40 it effecting in the original memory..
            Console.ReadLine();

        }
        static void MethodValue(int a)
        {
            a = a + 10;
            Console.WriteLine("value of A in method value " + a);
        }
        static void MethodRef(ref int b)
        {
            b = b + 20;
            Console.WriteLine("value of b in methodref " + b);

        }
    }
}
