using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Domain
{
    public class Order : IOrder
    {
        public int Id { get; private set; }
        public string BuyerEmail { get; private set; }
        public string ShipToCity { get; private set; }
        public decimal TotalWeightKg { get; private set; }
        public ILineItem[] Items { get; private set; }
        public OrderStatus Status { get; set; }

        public Order(int id, string email, string city, decimal weight, ILineItem[] items)
        {
            Id = id;
            BuyerEmail = email;
            ShipToCity = city;
            TotalWeightKg = weight;
            Items = items;
            Status = OrderStatus.Created;
        }
    }

}
