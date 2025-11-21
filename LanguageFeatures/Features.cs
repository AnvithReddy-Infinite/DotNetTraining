using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    internal class Features
    {  //features ...net 2.0 3.0 3.5 4x....
        public void NullableDemo()
        {    //it is applicable only for value types but not for reference types because by default ref types have null
            //it represent value-type variable that can be asigned valueof null
            //nullable types are achived by ? symbol..,very widely used in database programming
            //if we add ? we can able to assign null for value types.
            //use HasValue and Value 
            string name = null;//valid
            int? age = null;//valid int age= null => it is invalid...
            if (age.HasValue)//checking
            {
                Console.WriteLine(age.Value);//retriving the value..
            }
            else
            {
                Console.WriteLine("no value assigned");
            }
        }
        public void GlobalNsDemo()
        {
            //working with namespace
            //how do u call hi method??
            //using global namespace we can call the class which is outside the namespace 
            //using global::
            c1 ob = new c1();
            ob.Display();

            global::c1 ob2 = new global::c1();
            ob2.Hi();
        }
        public void inlineDemo()
        {
            //feature : working with warning messages
            //how to remove warning msgs??
#pragma warning disable
            int x;//disable
            int y;
#pragma warning restore
            int z;//restore

        }
        public void ExtensionDemo()
        {  //extension method
           //feature:creating custom method to built in types
           //string s = "hello";
           //does it starts with h or not??
           //is it uppercase or not??
           //to add our custom method into the list of builtin methods 
           //conditions:1.class and method is static..
           //  2.method has to take atleast 1 parameter..


            int x = 10; //to know x is even or od??
            Console.WriteLine(x.IsEven());//we are attaching iseven here ..

        }
        //object initialiazer
        public void propertyDemo()
        {//feature:best way to initialize property
            student s1 = new student()
            {
                studentId = 1,
                name = "monika",
            };
            Console.WriteLine($"{s1.studentId} {s1.name}");
        }
        public void CollectionDemo()
        {//collection initilizer..
         //feature:easy abd best way to initialise List
         //List<student>s1=new List<student>();
         //student ob1 = new student();
         //ob1.studentId = 1;
         //ob1.name = "monika";

            //student ob2 = new student();
            //ob2.studentId = 2;
            //ob2.name = "teja";
            //student ob3 = new student()
            //{
            //    studentId = 2,
            //    name = "teja"
            //};
            //s1.Add(ob1);
            //s1.Add(ob2);
            //s1.Add(ob3);
            //s1.Add(new student() { studentId=4,name="moni"});

            //collection inialitizer
            List<student> s1 = new List<student>() { (new student() { studentId = 4, name = "moni" }),
            (new student() { studentId=2,name="monika"}),
            (new student() { studentId=3,name="moni2"}),
            (new student() { studentId=4,name="moni3"})};


            foreach (var item in s1)
            {
                Console.WriteLine($"{item.studentId},{item.name}");
            }

        }
    }
    static class myclass
    { //attach this for int datatype 
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }
    }

    public class c1
    {
        public void Display()
        {
            Console.WriteLine("display");
        }
    }
}

public class c1
{
    public void Hi()
    {
        Console.WriteLine("hi called");
    }
}

class student
{//write prop and press tab for 2 timess.
    public int studentId { get; set; }
    public string name { get; set; }
    //write propfull and press tab for 2 times
    //public int MyProperty
    //{
    //    get { return myVar; }
    //    set { myVar = value; }
    //}

}








