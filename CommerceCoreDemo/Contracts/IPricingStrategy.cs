using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Contracts
{
    public interface IPricingStrategy
    {
        decimal CalculateTotal(ILineItem[] items);
    }

}
