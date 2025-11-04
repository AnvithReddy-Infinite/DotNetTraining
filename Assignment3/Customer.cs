using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Customer
    {
        public string Name;
        public string Phone;
        public int LoyaltyPoints;
        public Customer(string name, string phone, int points)
        {
            Name = name;
            Phone = phone;
            LoyaltyPoints = points;
        }
    }
}
