using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Shipping
{
    public abstract class ShipmentQuoterBase : IShipmentQuoter
    {
        public abstract decimal Quote(IOrder order);
    }

}
