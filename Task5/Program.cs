using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter bill amount: ");
            double billAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter total people: ");
            int people = Convert.ToInt32(Console.ReadLine());

            double finalBill = billAmount;

            if (billAmount > 1000)
            {
                double gst = billAmount * 0.05; 
                double serviceCharge = billAmount * 0.10;
                finalBill += gst + serviceCharge;
            }

            double perPerson = finalBill / people;

            Console.WriteLine("Each person should pay: Rs" + Math.Round(perPerson));
            Console.ReadLine();

        }
    }
}
