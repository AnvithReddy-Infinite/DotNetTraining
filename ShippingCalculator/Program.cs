using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCalculator
{
    public abstract class ShippingCalculator
    {
        // Abstract: must be implemented in each service
        public abstract decimal Calculate(decimal weight, string zone);

        // Virtual label: can be overridden for service name/SLA
        public virtual string Label()
        {
            return "Shipping Service";
        }
    }

    // Standard shipping: 3 days SLA
    public class StandardShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            // example slab: base ₹40, add ₹20/kg (zone A), ₹25/kg (zone B)
            decimal baseCost = 40;
            decimal perKg = (zone == "A") ? 20 : 25;
            return baseCost + perKg * weight;
        }

        public override string Label()
        {
            return "Standard Shipping (SLA: 3 days)";
        }
    }

    // Express shipping: 1 day SLA
    public class ExpressShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            // slab: base ₹80, ₹40/kg everywhere, extra ₹30 if >5kg
            decimal cost = 80 + 40 * weight;
            if (weight > 5) cost += 30;
            return cost;
        }

        public override string Label()
        {
            return "Express Shipping (SLA: 1 day)";
        }
    }

    // International shipping: 5-10 days SLA
    public class InternationalShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            // slab: ₹200 base, ₹95/kg for zone "Asia", ₹120/kg for "Europe"
            decimal baseCost = 200;
            decimal perKg = (zone == "Asia") ? 95 : 120;
            return baseCost + perKg * weight;
        }

        public override string Label()
        {
            return "International Shipping (SLA: 5-10 days)";
        }
    }

    // Example test (unit-test friendly)
    class Program
    {
        static void Main()
        {
            // Shipping objects
            ShippingCalculator std = new StandardShipping();
            ShippingCalculator exp = new ExpressShipping();
            ShippingCalculator intl = new InternationalShipping();

            // Test calls with sample values
            decimal stdCost = std.Calculate(3.0M, "A");
            decimal expCost = exp.Calculate(6.5M, "B");
            decimal intlCost = intl.Calculate(2.2M, "Asia");

            // Print
            Console.WriteLine($"{std.Label()} -> Cost for 3kg (Zone A): Rs{stdCost}");
            Console.WriteLine($"{exp.Label()} -> Cost for 6.5kg: Rs{expCost}");
            Console.WriteLine($"{intl.Label()} -> Cost for 2.2kg (Asia): Rs{intlCost}");
        }
    }
}
