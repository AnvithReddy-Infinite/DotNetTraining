using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Observer;
using static DesignPatterns.books;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args) {
            //
            //var ob = Factory.GetInstance(3);
            //var result = ob.ShowData();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //IPrinter p = new ModernPrinter();
            //p.Print("hello world");

            //LegacyPrinter o = new LegacyPrinter();
            //IPrinter p2 = new LegacyPrinterAdapter(o);
            //p2.Print("good afternoon");// calls the older printer




            //
            // user -1
            //Class1 ob = new Class1();
            //ob.p1 = 100;
            //ob.p2 = 200;
            //Console.WriteLine(ob.p1);
            //Console.WriteLine(ob.p2);
            //Console.WriteLine("====================");

            //// user-2
            ////Class1 ob2 = ob; // single object
            //Class1 ob2 = (Class1)ob.Clone(); //2 objects
            //ob2.p2 = 500;
            //Console.WriteLine(ob2.p1);
            //Console.WriteLine(ob2.p2);

            //Console.WriteLine("==================");
            //Console.WriteLine(ob.p1);// 100
            //Console.WriteLine(ob.p2);//500
            //                         // why user1 data is getting updated?


            //// Observer Pattern Demo
            //NotificationService notificationService = new NotificationService();

            //User user1 = new User("Apporv");
            //User user2 = new User("Prince");
            //User user3 = new User("Rathan");
            //User user4 = new User("Satish");

            //notificationService.Subscribe(user1);
            //notificationService.Subscribe(user2);
            //notificationService.Subscribe(user3);
            //notificationService.Subscribe(user4);

            //notificationService.NotifyObservers("Hello Students Happy Week end!");


            //Console.WriteLine("=================");
            //notificationService.Unsubscribe(user4);

            //notificationService.NotifyObservers("Have a Great Day!!!");

            //Facade pattern
            // first
            //login ob = new login();
            //product p = new product();
            //makepayment m = new makepayment();
            //sendmail s = new sendmail();

            //// second time
            //facedpattern ob1 = new facedpattern();
            //ob1.buyproduct();

            // Template pattern
            books obj = new onlinedelivery();
            obj.ProcessData();
            Console.WriteLine("==================");
            obj = new physicaldelivery();
            obj.ProcessData();


        }
    }
}
