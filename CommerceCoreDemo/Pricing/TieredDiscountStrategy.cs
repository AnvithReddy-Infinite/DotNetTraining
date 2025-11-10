using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Pricing
{
    public class TieredDiscountStrategy : IPricingStrategy
    {
        public decimal CalculateTotal(ILineItem[] items)
        {
            decimal sum = 0;
            foreach (var item in items)
                sum += item.Price * item.Quantity;
            if (sum >= 15000)
                return sum * 0.88M; // 12% off
            if (sum >= 5000)
                return sum * 0.95M; // 5% off
            return sum;
        }
    }

}
