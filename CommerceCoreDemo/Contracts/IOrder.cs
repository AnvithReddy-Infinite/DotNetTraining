using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommerceCoreDemo.Domain;


namespace CommerceCoreDemo.Contracts
{
    public interface IOrder
    {
        int Id { get; }
        string BuyerEmail { get; }
        string ShipToCity { get; }
        decimal TotalWeightKg { get; }
        ILineItem[] Items { get; }
        OrderStatus Status { get; set; }
    }

}
