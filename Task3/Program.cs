using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter purchase amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double discountRate = 0;

            if (amount < 1000)
            {
                discountRate = 0;
            }
            else if (amount <= 5000)
            {
                discountRate = 10;
            }
            else
            {
                discountRate = 20; 
            }

            double discountAmount = amount * discountRate / 100;

            double finalAmount = amount - discountAmount;

            Console.WriteLine("Final amount after discount: Rs" + finalAmount);
            Console.ReadLine();

        }
    }
}


