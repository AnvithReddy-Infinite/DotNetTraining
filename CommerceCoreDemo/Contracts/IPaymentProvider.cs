using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Contracts
{
    public interface IPaymentProvider
    {
        bool AuthorizePayment(IOrder order, out string failureReason);
        bool CapturePayment(IOrder order, ref bool isCaptured);
    }

}
