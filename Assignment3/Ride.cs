using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Ride
    {
        public Customer Customer;
        public Vehicle Vehicle;
        public DateTime RideDate;
        public decimal Km;
        public string[] AddOns;
        public decimal Coupon;

        public Ride(Customer cust, Vehicle veh, DateTime date, decimal km, string[] addOns, decimal coupon)
        {
            Customer = cust;
            Vehicle = veh;
            RideDate = date;
            Km = km;
            AddOns = addOns;
            Coupon = coupon;
        }

        public void ComputeBill(out decimal subtotal, out decimal gst, out decimal total, out decimal couponApplied, out int loyaltyApplied)
        {
            subtotal = Vehicle.BaseFare + (Vehicle.PerKmRate * Km) + Pricing.AddOnsCost(AddOns);
            bool isWeekend = Pricing.TryGetWeekendSurcharge(RideDate, out decimal wendSurcharge);
            if (isWeekend) subtotal += subtotal * wendSurcharge / 100M;

            gst = Pricing.CalculateGST(subtotal);
            total = subtotal + gst;
            couponApplied = 0;
            loyaltyApplied = 0;

            // Call by value coupon demonstration:
            decimal demoValue = Pricing.TryApplyCoupon_ByValue(total, Coupon);

            // Actual coupon: by ref
            Pricing.ApplyCoupon_ByRef(ref total, Coupon, out couponApplied);

            // Loyalty: by ref
            Pricing.RedeemLoyalty(ref Customer.LoyaltyPoints, ref total, out loyaltyApplied);

            // Output demo (for invoice)
            Console.WriteLine("(Demonstration) Call-by-VALUE coupon attempt did NOT change total: Rs{0:0.00}", demoValue);
        }

        public void PrintInvoice(decimal subtotal, decimal gst, decimal total, decimal couponApplied, int loyaltyApplied)
        {
            Console.WriteLine("========== RideEasy Invoice ==========");
            Console.WriteLine("Date: {0:dd-MMM-yyyy (ddd)}", RideDate);
            Console.WriteLine("Customer: {0} ({1})", Customer.Name, Customer.Phone);
            Console.WriteLine("Vehicle: {0}", FirstCharToUpper(Vehicle.Type));
            Console.WriteLine("Distance: {0:0.0} km", Km);
            Console.WriteLine("Add-Ons: {0}", AddOns.Length > 0 ? string.Join(", ", AddOns) : "None");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Subtotal:         Rs {0,7:0.00}", subtotal);
            Console.WriteLine("GST (18%):        Rs {0,7:0.00}", gst);
            Console.WriteLine("Total (before):   Rs {0,7:0.00}", subtotal + gst);
            Console.WriteLine("Coupon (by REF):  - applied Rs{0:0.00}", couponApplied);
            Console.WriteLine("Loyalty redeem:   - applied up to available points");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Final Payable:    Rs {0,7:0.00}", total);
            Console.WriteLine("--------------------------------------");
            // Demo line (already printed in ComputeBill)
            // Remaining points
            Console.WriteLine("Remaining Loyalty Points: {0}", Customer.LoyaltyPoints);
            Console.WriteLine("======================================");
        }

        // Helper to make vehicle type first letter uppercase
        static string FirstCharToUpper(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }


       
        }
    }

