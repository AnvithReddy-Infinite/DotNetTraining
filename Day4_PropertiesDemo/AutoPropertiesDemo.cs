using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Day4_PropertiesDemo
{
    class Customer
    {
        // Auto-Implemented Properties
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer ID: " + CustomerID);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone Number: " + PhoneNumber);
        }
    }
    internal class AutoPropertiesDemo
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine(" Enter the customer Id, Name, Email, Phone Number");
            customer.CustomerID = Convert.ToInt32(Console.ReadLine());
            customer.CustomerName = Console.ReadLine();
            customer.Email = Console.ReadLine();
            Console.WriteLine("enter phonenumber");
            customer.PhoneNumber = Console.ReadLine();
            customer.DisplayCustomerInfo();
        }
    }
}
