using CommerceCoreDemo.Contracts;
using CommerceCoreDemo.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Payments
{
    public sealed class StripeProvider : PaymentProviderBase
    {
        public override bool AuthorizePayment(IOrder order, out string failureReason)
        {
            failureReason = "";
            return true; // Simulated - always succeeds for demo
        }

        public override bool CapturePayment(IOrder order, ref bool isCaptured)
        {
            if (captured)
                throw new PaymentAlreadyCapturedException("Payment already captured");
            captured = true;
            isCaptured = captured;
            return true;
        }
    }

}
