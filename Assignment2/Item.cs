using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Item
    {
        public string Name;
        public int Quantity;
        public double PricePerUnit;

        // Calculate total for this item
        public void CalculateTotal(out double itemTotal)
        {
            itemTotal = Quantity * PricePerUnit;
        }
    }
}
