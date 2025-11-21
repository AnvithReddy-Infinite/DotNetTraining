using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //public  delegate string SampleFunctionDelegate(int x, int y);
    internal class FuncDelegateDemo
    {
        static void Main(string[] args)
        {
            //SampleFunctionDelegate sampleFuncDel = Add;
            //string result = sampleFuncDel(10, 20);
            //Console.WriteLine(" Result = "+result);

            //Example 2 Function Delagete
            Func<int, int, string> funcDelegate = Add;
            string res = funcDelegate(100, 200);
            Console.WriteLine(" \nREsult " + res);


            //Function delegate with anonymous method

            Func<int, string> funcDel = delegate (int a)
            {
                return "Hello " + (a).ToString();
            };
            Console.WriteLine("\n Function with anonymous delegate " + funcDel(50));

            ///example 4 Function delegate with Lambda Expression
            ///
            Func<int, string> funcDelLambda = a => "Hello from Lambda " + (a).ToString();
            Console.WriteLine("\n Function with Lambda Expression " + funcDelLambda(75));
            Console.ReadLine();
        }
        public static string Add(int a, int b)
        {
            return (a + b).ToString();
        }
    }
}
 

