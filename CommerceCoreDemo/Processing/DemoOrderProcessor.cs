using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Processing
{
    public class DemoOrderProcessor : OrderProcessorBase
    {
        protected override void Validate(IOrder order)
        {
            foreach (var item in order.Items)
            {
                if (item.Quantity <= 0 || item.Price <= 0)
                    throw new System.ArgumentException("Invalid line item");
            }
            System.Console.WriteLine("Order validated!");
        }

        // You can override other protected methods for more detailed demo logic as needed.
    }

}
