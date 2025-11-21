using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void PrintNumberDelegate(int number);
    public delegate string GreetDelegate(string str);
    internal class DeletageDemo
    {
        public static void Main(string[] args)

        {

            PrintNumberDelegate printNumberDelegate = PrintNumber;

            GreetDelegate greetDel = GreetMessage;

            printNumberDelegate(15000);

            printNumberDelegate(25000);

            printNumberDelegate += DisplayMessage;

            printNumberDelegate += ShowDate;

            Console.WriteLine("\n\n Multicast Delegat Demo");

            printNumberDelegate(300000);

            printNumberDelegate -= DisplayMessage;

            Console.WriteLine("\n\n MultiCast Delegate Demo after removing reference of DisplayMessage");

            printNumberDelegate(30000);
            Console.WriteLine(greetDel("John"));
            Console.ReadLine();

        }

        public static void PrintNumber(int number)

        {

            Console.WriteLine("number {0:C}:", number);

        }

        public static void DisplayMessage(int customerId)

        {

            Console.WriteLine($" Hello from {customerId}");

        }

        public static void ShowDate(int date)

        {

            Console.WriteLine(DateTime.Now.ToShortDateString());

        }

        public static string GreetMessage(string str)

        {
            return "Hello" + str;
        }

    }

}
 
