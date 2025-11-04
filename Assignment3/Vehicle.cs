using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Vehicle
    {
        public string Type;
        public decimal BaseFare;
        public decimal PerKmRate;
        public Vehicle(string type)
        {
            // Minimal fixed fares
            Type = type.ToLower();
            if (Type == "sedan") { BaseFare = 80; PerKmRate = 14; }
            else if (Type == "suv") { BaseFare = 120; PerKmRate = 18; }
            else { BaseFare = 50; PerKmRate = 12; Type = "hatchback"; }
        }
    }
}
