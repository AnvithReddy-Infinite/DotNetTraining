using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class UtilityBilling
    {
        public static double GetServiceCharge()
        {
            return 50.0;
        }

        // Static method: returns the tax applied (say 10% for simplicity)
        public static double CalculateTax(double billAmount)
        {
            return billAmount * 0.10; // 10% tax
        }
    }
}
