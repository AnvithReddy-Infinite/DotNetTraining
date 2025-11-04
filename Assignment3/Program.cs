using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Customer Name: ");
            string cname = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phone = Console.ReadLine();
            Console.Write("Loyalty points: ");
            int loyalty = 0;
            int.TryParse(Console.ReadLine(), out loyalty);

            var customer = new Customer(cname, phone, loyalty);

            Console.Write("Vehicle (Hatchback/Sedan/SUV): ");
            string vtype = Console.ReadLine();
            var vehicle = new Vehicle(vtype);

            Console.Write("Distance in km (e.g. 15.8): ");
            decimal km = 0;
            decimal.TryParse(Console.ReadLine(), out km);

            Console.Write("Ride date (yyyy-mm-dd): ");
            string dateStr = Console.ReadLine();
            DateTime rDate = DateTime.Today;
            DateTime.TryParse(dateStr, out rDate);

            Console.Write("Add-ons (comma separated, or leave blank): ");
            string[] addons = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < addons.Length; i++) addons[i] = addons[i].Trim();

            Console.Write("Coupon amount (Rs, 0 if none): ");
            decimal coupon = 0;
            decimal.TryParse(Console.ReadLine(), out coupon);

            var ride = new Ride(customer, vehicle, rDate, km, addons, coupon);

            ride.ComputeBill(out decimal sub, out decimal gst, out decimal total, out decimal couponUsed, out int pointsUsed);

            ride.PrintInvoice(sub, gst, total, couponUsed, pointsUsed);
        
    }
    }
}
