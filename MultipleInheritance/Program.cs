using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MultipleInheritance.Review;

namespace MultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GetProductInfo();
            customer.GetReviews();
            Console.WriteLine("\n Product Details and Customer Reviews\n ------------------");
            customer.DisplayProductInfo();
            customer.DisplayReviews();
            Console.ReadLine();
        }
    }
}
