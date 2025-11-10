using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.ProcessPayment(3000);
            creditCardPayment.samplePayment();
            Console.WriteLine($"{creditCardPayment.Provider}");
            CashOnDelivery CashOnDelivery = new CashOnDelivery();
            CashOnDelivery.ProcessPayment(7000);
            Console.ReadLine();
        }
    }
}
