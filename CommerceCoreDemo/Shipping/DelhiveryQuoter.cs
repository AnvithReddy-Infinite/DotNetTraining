using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Shipping
{
    public sealed class DelhiveryQuoter : ShipmentQuoterBase
    {
        public override decimal Quote(IOrder order)
        {
            decimal price = 50 + 28 * order.TotalWeightKg;
            if (order.ShipToCity == "Remote")
                price *= 1.08M; // 8% surcharge for remote
            return price;
        }
    }

}
