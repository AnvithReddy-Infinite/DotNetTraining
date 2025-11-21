using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    internal class Class2
    {
        public delegate object mydel();
        public delegate void mydel2(string st);
        public string cov() { return "hi"; }
        public void con(object st) { Console.WriteLine("hello"); }

        public void NamedoptionalDemo(int x = 10, int y = 30)
        {
            int result = x + y;
            Console.WriteLine("The Sum is :" + result);
        }

        // Drawback of this optional parameter is it may not run if we use function overloading
        public void NamedoptionalDemo()
        {
            Console.WriteLine("Hello World");
        }

        public void CoVariance_Contravariance()
        {
            // Covariance and Contravariance in C# are advanced concepts related to type compatibility and conversion.
            // Covariance allows a method to return a more derived type than originally specified.
            // Contravariance allows a method to accept parameters of a less derived type than originally specified.
            // Use a derived type instead of the base type

            mydel d = cov;
            Console.WriteLine(d());

            mydel2 d2 = con;
            d2("hi");

        }



        // Dynamic Typing Demo
        dynamic d;//we can declare it
        dynamic e = null;    //we can assign null value
        public void dynamicDemo()//(dynamic a )we can pass as a parameter
        {//var:varient
         //var a = 100;//if we dont know what data type we have to asign then use var .
         //var b = "string";//datatype checked at compile time
         //var a2 = a * b;//at compile time it si checking
         //int p, q, r;//valid
         //var m, n, o;//invalid

            //b = "b";//valid
            //b = 2;//invalid

            //int x;
            //x = 10;//valid 
            //var p;
            //p = 10;//invalid

            //1.var cant be declared globally
            //2.multiple var variables not allowed in a single line.
            //3.you have to assign values ie,var a;a=10//invalid
            //4.null values cant be assignes ie,var a=null//invalid
            //5.cant be used as a function parameter ie,demo(var a )
            //dynamic m = 100;//more flexible than var
            ////datatype checked at runtime
            //dynamic n = "string";
            //dynamic o = m * n;//here it will not show error but while runtime it will
            dynamic n1 = 10;//integer
            Console.WriteLine(n1);
            n1 = "hii";//string
            Console.WriteLine(n1);
            n1 = 10.5;//double
            Console.WriteLine(n1);

        }


    }
}
