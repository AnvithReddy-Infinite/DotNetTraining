using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter show time (24-hr format): ");
            int showTime = Convert.ToInt32(Console.ReadLine());

            int price = 0;

            if (age < 12)
            {
                price = 150;
            }
            else if (showTime < 18)
            {
                price = 250;
            }
            else
            {
                price = 300;
            }

            Console.WriteLine("Ticket price: Rs" + price);
            Console.ReadLine();

        }
    }
}
