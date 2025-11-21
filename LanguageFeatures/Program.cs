using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Features.cs
            Features features = new Features();
            features.NullableDemo();
            features.GlobalNsDemo();
            features.ExtensionDemo();
            features.propertyDemo();
            features.CollectionDemo();

            // Feature6.cs
            //Feature6 ob = new Feature6();
            //ob.staticDemo();
            //ob.autoinitdemo();
            //ob.dictionaryDemo();
            //ob.nameofexpressionsdemo();
            //ob.Expressionbody();

            // TaskDemo.cs
            TaskDemo t = new TaskDemo();
            t.Method3();

            // Class2.cs
            Class2 obj = new Class2();
            obj.NamedoptionalDemo(y: 50);


            //ob.Covariance_Contravariance();

            Csharp7 ob = new Csharp7();
            // TUPLE DEMO
            //var res = ob.tupledemo();
            //Console.WriteLine("id " + res.Item1);
            //Console.WriteLine("name " + res.Item2);

            // DECONSTRUCTION OF TUPLE
            //(var id, var name) = ob.tupledemo();
            //Console.WriteLine("id " + id);
            //Console.WriteLine("name " + name);

            //// OutKeyword demo
            //ob.outdemo();
            //// Pattern Matching demo
            //ob.patternmatchingdemo();
            //// Readability demo
            //ob.Readability();
            //// Local Function demo
            //ob.localfunction();



            Console.ReadLine();

        }
    }
}

