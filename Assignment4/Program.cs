using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Welcome to Online Utility Billing System ===========");
            Console.Write("Enter number of customers: ");
            int numCustomers = Convert.ToInt32(Console.ReadLine());

            // For multiple customers (uses a loop & array)
            Customer[] customers = new Customer[numCustomers];

            double unitRate = 5.0; // For simplicity, set unit cost per reading

            for (int i = 0; i < numCustomers; i++)
            {
                Console.WriteLine($"\nEnter details for Customer #{i + 1}");
                Console.Write("Customer ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Customer Name: ");
                string name = Console.ReadLine();

                // Read usage readings using params
                Console.Write("Enter monthly usage readings (space separated, e.g. 120 130 125):\n");
                string[] inputReadings = Console.ReadLine().Split(' ');
                double[] readings = new double[inputReadings.Length];

                // Convert readings from string to double, using explicit conversion
                for (int j = 0; j < inputReadings.Length; j++)
                {
                    double value = 0;
                    double.TryParse(inputReadings[j], out value); // out with discard possible
                    readings[j] = value; // Store the converted value
                }

                // Create customer and store in array
                customers[i] = new Customer(id, name);

                // Compute total usage using params method
                double totalUnits = customers[i].TotalUsage(readings);

                // Now calculate the bill using out parameters
                double total, tax, netPayable;
                customers[i].CalculateBill(unitRate, out total, out tax, out netPayable);

                // Print bill as per sample
                Console.WriteLine("\n ====== Utility Bill ======");
                Console.WriteLine($"Customer ID     : {id}");
                Console.WriteLine($"Customer Name   : {name}");
                Console.WriteLine($"Service Charge  : Rs{UtilityBilling.GetServiceCharge():0.00}");
                Console.WriteLine($"Total Usage     : Rs{total:0.00}");
                Console.WriteLine($"Tax Applied     : Rs{tax:0.00}");
                Console.WriteLine($"Net Payable     : Rs{netPayable:0.00}");
                Console.WriteLine($"============================");
            }

            Console.WriteLine("\nAll customer bills processed successfully!");
    }
    }
}
