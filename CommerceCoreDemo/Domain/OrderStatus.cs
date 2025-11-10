using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Domain
{

    public enum OrderStatus
    {
        Created,
        Authorized,
        Captured,
        Shipped
    }
}
