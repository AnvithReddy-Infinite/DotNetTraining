using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo.Processing
{
    public abstract class OrderProcessorBase
    {
        // Template method, orchestrates all steps
        public void ProcessAsync(IOrder order)
        {
            Validate(order);
            Price(order);
            AuthorizePayment(order);
            ReserveStock(order);
            QuoteShipment(order);
            CapturePayment(order);
            CreateShipment(order);
            SendNotifications(order);
            Persist(order);
        }

        protected virtual void Validate(IOrder order)
        {
            System.Console.WriteLine("Validating order...");
        }

        protected virtual void Price(IOrder order)
        {
            System.Console.WriteLine("Pricing order...");
        }

        protected virtual void AuthorizePayment(IOrder order)
        {
            System.Console.WriteLine("Authorizing payment...");
        }

        protected virtual void ReserveStock(IOrder order)
        {
            System.Console.WriteLine("Reserving stock...");
        }

        protected virtual void QuoteShipment(IOrder order)
        {
            System.Console.WriteLine("Quoting shipment...");
        }

        protected virtual void CapturePayment(IOrder order)
        {
            System.Console.WriteLine("Capturing payment...");
        }

        protected virtual void CreateShipment(IOrder order)
        {
            System.Console.WriteLine("Creating shipment...");
        }

        protected virtual void SendNotifications(IOrder order)
        {
            System.Console.WriteLine("Sending notifications...");
        }

        protected internal virtual void Persist(IOrder order)
        {
            System.Console.WriteLine("Persisting order...");
        }

        private protected void FraudScore()
        {
            // (Demo) Sensitive code for fraud scoring, not overridable
        }
    }

}
