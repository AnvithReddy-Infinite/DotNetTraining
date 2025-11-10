using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Pricing
{
    public class MRPStrategy : IPricingStrategy
    {
        public decimal CalculateTotal(ILineItem[] items)
        {
            decimal sum = 0;
            foreach (var item in items)
                sum += item.Price * item.Quantity;
            return sum;
        }
    }

}
