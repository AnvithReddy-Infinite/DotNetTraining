using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Shipping
{
    public sealed class BluedartQuoter : ShipmentQuoterBase
    {
        public override decimal Quote(IOrder order)
        {
            decimal price = 60 + 25 * order.TotalWeightKg;
            if (order.ShipToCity == "Metro")
                price *= 0.9M; // 10% discount for metro
            return price;
        }
    }

}
