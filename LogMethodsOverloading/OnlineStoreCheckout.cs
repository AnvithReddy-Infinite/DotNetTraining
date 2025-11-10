using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMethodsOverloading
{
    class Onlinestore
    {
        public void Checkout(int price)
        {
            Console.WriteLine("the price of product is " + price);
        }
        public void Checkout(int price, int quantity)
        {
            Console.WriteLine($"the price of product is {price} and quantity is {quantity}");
            int amount = price * quantity;
            Console.WriteLine("the amount is " + amount);
        }
        public void Checkout(int price, int quantity, string couponCode)
        {
            Console.WriteLine($"the coupon code of product is {couponCode} price of product is {price} and quantity is {quantity}");
        }
    }
    internal class OnlineCheckout
    {
        static void Main(string[] args)
        {
            Onlinestore onlinestore = new Onlinestore();
            onlinestore.Checkout(300);
            onlinestore.Checkout(400, 4);
            onlinestore.Checkout(500, 2, "ABC101");
            Console.ReadLine();
        }
    }
}
