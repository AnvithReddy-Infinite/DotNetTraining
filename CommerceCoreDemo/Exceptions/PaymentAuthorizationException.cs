using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Exceptions
{
    public class PaymentAuthorizationException : Exception
    {
        public PaymentAuthorizationException(string message)
            : base(message)
        {
        }
    }
}
