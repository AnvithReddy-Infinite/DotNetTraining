using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Customer
    {
        public int CustomerID;
        public string CustomerName;
        public double[] Readings; // Array to store usage readings

        // Constructor: sets up the customer object
        public Customer(int id, string name)
        {
            CustomerID = id;
            CustomerName = name;
        }

        // Non-static method: calculates bill details for the customer
        public void CalculateBill(double rate, out double total, out double tax, out double netPayable)
        {
            total = 0;
            if (Readings != null)
            {
                // Add up all readings using loop
                for (int i = 0; i < Readings.Length; i++)
                {
                    total += Readings[i] * rate;
                }
            }
            // Service charge and tax
            double serviceCharge = UtilityBilling.GetServiceCharge();
            tax = UtilityBilling.CalculateTax(total);
            netPayable = total + serviceCharge + tax;
        }

        // Params method: accepts variable number of readings, calculates total usage units
        public double TotalUsage(params double[] readings)
        {
            double totalUnits = 0;
            foreach (double r in readings)
            {
                totalUnits += r;
            }
            // Store readings in the object for use elsewhere
            Readings = readings;
            return totalUnits;
        }
    }
}
