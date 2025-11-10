using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingDemo
{
    public class CashOnDelivery : PaymentMethod
    {
        public override string Provider => "Cash On Delivery";



           ////public override bool ProcessPayment(decimal amount)
            //{
          //if (amount > 0 && amount <= 10000) // Assuming a limit for cash on delivery payments
            //{
        //Console.WriteLine($"Processing cash on delivery payment of {amount:c} through {Provider}.")
        //return true;
            //}
            //else
            //{
        //Console.WriteLine("Cash on delivery payment failed: Amount exceeds limit or is invalid.");
        //return false;
            //}
            //}

} 
}
