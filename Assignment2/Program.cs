using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Smart Grocery Billing System =====");
            Console.Write("Enter number of items: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Array for items
            Item[] items = new Item[n];

            double grandTotal = 0;

            // Input for each item
            for (int i = 0; i < n; i++)
            {
                items[i] = new Item();
                Console.WriteLine($"\nEnter details for Item #{i + 1}");

                Console.Write("Enter item name: ");
                items[i].Name = Console.ReadLine();

                Console.Write("Enter quantity: ");
                items[i].Quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price per unit: ");
                items[i].PricePerUnit = Convert.ToDouble(Console.ReadLine());

                double itemTotal;
                items[i].CalculateTotal(out itemTotal);
                grandTotal += itemTotal;
            }

            // Calculate discount
            double discount = 0;
            if (grandTotal > 5000)
            {
                discount = 0.20 * grandTotal;
            }
            else if (grandTotal >= 2000)
            {
                discount = 0.10 * grandTotal;
            }
            else if (grandTotal >= 1000)
            {
                discount = 0.05 * grandTotal;
            }
            // else discount = 0 (No discount for below 1000)

            double finalAmount = grandTotal - discount;

            // Print Bill
            Console.WriteLine("\n===== Bill Receipt =====");
            Console.WriteLine("{0,-15}{1,10}{2,15}{3,15}", "Item", "Quantity", "Price/Unit", "Total");

            for (int i = 0; i < n; i++)
            {
                double itemTotal;
                items[i].CalculateTotal(out itemTotal);
                Console.WriteLine("{0,-15}{1,10}{2,15:F2}{3,15:F2}",
                    items[i].Name, items[i].Quantity, items[i].PricePerUnit, itemTotal);
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("{0,-40} {1,8:F2}", "Grand Total:", grandTotal);
            Console.WriteLine("{0,-40} {1,8:F2}", "Discount:", discount);
            Console.WriteLine("{0,-40} {1,8:F2}", "Final Amount:", finalAmount);
            Console.WriteLine("===============================================");
        }
    }
}
