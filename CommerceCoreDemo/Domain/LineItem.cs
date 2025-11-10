using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Domain
{
    public class LineItem : ILineItem
    {
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public LineItem(int qty, decimal price)
        {
            if (qty <= 0 || price <= 0)
                throw new ArgumentException("Invalid line item");
            Quantity = qty;
            Price = price;
        }
    }

}
