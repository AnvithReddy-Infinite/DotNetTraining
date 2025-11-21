using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    internal class Csharp7
    {
        //public (int, string) tupledemo()
        //{  //TUPLES
        //   //   Features: using tuple we can return multiple values
        //   //now its standards
        //    int id = 104;
        //    string name = "Anvith";
        //    return (id, name);

        //}

        //public void outdemo()
        //{//converting from string to integer we have to use parsemethod
         //int.Parse;//converts string to integer
         //double.Parse//converts string to double
         //float.Parse //Converts string to float
         //int a = int.Parse(Console.ReadLine());//here when we enter a string it will throw a error
            //int x;
        //    var res = int.TryParse(Console.ReadLine(), out int x);
        //    Console.WriteLine(x);

        //    if (res == true)
        //        Console.WriteLine(x);
        //    else Console.WriteLine("failed");
        //}

        //public void patternmatchingdemo()
        //{
            //object shape = "Circle";
            //Console.WriteLine(shape.GetType().Name);
            //switch (shape.GetType().Name)
            //{
            //    case "Int32":
            //        int n = (int)shape;
            //        if (n > 0)
            //            Console.WriteLine("Positive number");
            //        else

            //            Console.WriteLine("Unknown");
            //        break;

            //    case "String":
            //        string s = (string)shape;
            //        if (s == "Circle")
            //            Console.WriteLine("It's a circle");
            //        else
            //            Console.WriteLine("Unknown");
            //        break;

            //    default:
            //        Console.WriteLine("Unknown");
            //        break;
            //}


            //object shape = "Circle";

            //switch (shape)
            //{
            //    case int n when n > 0:
            //        Console.WriteLine("Positive number");
            //        break;
            //    case string s when s == "Circle":
            //        Console.WriteLine("It's a circle");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown");
            //        break;
            //}


            //int marks = 82;
            //string result = marks switch
            //{
            //    >= 90 => "Excellent",
            //    >= 75 => "Good",
            //    >= 50 => "Average",
            //    _ => "Fail" // default
            //};
            //Console.WriteLine(result);
        //}

        // Readability with digit separators
        //public void Readability()
        //{
        //    // Feature: using _ isntead of ,
        //    int x = 10_000000;
        //    Console.WriteLine(x);
        //}

        public string localfunction(int a)
        {
            string greatest(int x)
            {
                if (x > 10)
                    return "x is greater than 10";
                else
                    return "x is lesser than 10";
            }
          return greatest(100);
        }

        public void throwexpdemo()
        { 
            // Older way
            string st = null;
            if(st==null)
                throw new ArgumentException("exp occurred");

                // New way
                string res =
                st ?? throw new ArgumentNullException("exp occurred");
        }


    }
}
