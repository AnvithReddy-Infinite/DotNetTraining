using CommerceCoreDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceCoreDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Commerce.Core Demo ===");

            // Create some line items
            ILineItem[] items = new ILineItem[]
            {
                new Domain.LineItem(2, 10000),    // quantity 2, price 10,000
                new Domain.LineItem(1, 8000)      // quantity 1, price 8,000
            };

            // Create order with samples
            IOrder order = new Domain.Order(
                id: 1,
                email: "buyer@example.com",
                city: "Metro",
                weight: 3.5M,
                items: items);

            // Pricing strategy - Tiered discount
            IPricingStrategy pricing = new Pricing.TieredDiscountStrategy();

            // Payment provider (sealed)
            IPaymentProvider payment = new Payments.RazorpayProvider();

            // Shipping quoter (sealed)
            IShipmentQuoter shipping = new Shipping.BluedartQuoter();

            // Notification providers
            INotifier emailNotifier = new Notifications.EmailNotifier();
            INotifier smsNotifier = new Notifications.SmsNotifier();

            // Processing with template method
            Processing.DemoOrderProcessor processor = new Processing.DemoOrderProcessor();

            // Run order pipeline
            processor.ProcessAsync(order);

            try
            {
                // Authorize payment
                string failure;
                bool authorized = payment.AuthorizePayment(order, out failure);
                if (!authorized) throw new Exceptions.PaymentAuthorizationException(failure);

                // Capture payment
                bool captured = false;
                payment.CapturePayment(order, ref captured);
                Console.WriteLine("Payment capture status: " + captured);

                // Shipment quote and choose cheapest
                decimal bluedartPrice = shipping.Quote(order);
                Console.WriteLine($"Bluedart Shipment Price: Rs:{bluedartPrice:0.00}");

                // Notifications
                emailNotifier.Notify(order.BuyerEmail, "Order shipped. Tracking info to follow.");
                smsNotifier.Notify(order.BuyerEmail, "Order shipped via SMS");
            }
            catch (Exceptions.PaymentAlreadyCapturedException ex)
            {
                Console.WriteLine("Error: Payment already captured.");
            }
            catch (Exceptions.PaymentAuthorizationException ex)
            {
                Console.WriteLine("Error: Payment authorization failed: " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Error in order processing.");
            }

        }
    }
}
