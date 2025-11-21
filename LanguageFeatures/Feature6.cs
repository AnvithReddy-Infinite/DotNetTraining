using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    internal class Feature6
    {
        //1.using static
        public void staticDemo()
        {  //feature:how to avoid console class every time
            //how to do you print hello world?
            //we will wrote using static System.Console..
            WriteLine("hello world");
            WriteLine("hii students");
            //how do u find square route
            var res = Math.Sqrt(100);
            var res1 = Sqrt(200);
            WriteLine(res);
            WriteLine(res1);
        }
        public void autoinitdemo()
        {
            //feature:how to initialize property without constructor
            employee e = new employee();
            WriteLine(e.empid);
            WriteLine(e.name);
        }

        public void dictionaryDemo()
        {//dictionary initilazer
         //feature :how to add values to dictionary without add method
            Dictionary<int, string> dc = new Dictionary<int, string>()
            {
                [100] = "Anvith",
                [200] = "Reddy",
            };
            //dc.Add(100, "moni");
            //dc.Add(200, "teja");
            foreach (var item in dc)
            {
                WriteLine(item);
            }
        }

        public void hi() { }
        public void nameofexpressionsdemo()
        {//nameofExpressions
         //feature :how do you print function name as it is??
         //we want function name for logging features
            WriteLine(nameof(hi));
        }

        public void ExceptionFilters()
        {
            // Features : working with multiple catch blocks
            //in previous version u can declare exception only once
            //based on the message call the corresponding catch block
            //we oftenly use this feature when working with exceptins
            try
            {
                throw new Exception("hello");
            }
            catch (Exception ex) when (ex.Message == "Minor")
            {
                Console.WriteLine("Handled minor exception.");
            }
            catch (Exception ex) when (ex.Message == "Major")
            {
                Console.WriteLine("Major error occured.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception.");
            }
        }

        public void conditionalnull()
        {//feature:how do u avoid null error or uninitialized object
         //without using if conditions we are using the ?. operator 
            employee e = null;//u have not initialised
            WriteLine(e?.empid);//print the value only if it is initialized..
            WriteLine(e?.name);
        }

        //FEATURE :how to print value in single line(without braces)
        //we will use =>
        public void Expressionbody() => WriteLine("hello students how are u all");

        class employee
        {//auto inializer property(constructor not required)
         //{public employee() { 
         //{//by defualt we will use constructors to assign values
         //    empid = 100;
         //    name = "anvith";
         //}
            public int empid { get; set; } = 207;
            public string name { get; set; } = "Anvith";
        }
    }
}
