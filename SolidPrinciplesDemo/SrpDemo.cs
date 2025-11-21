using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    internal class SrpDemo
    {
        //SRP : Single Responsibility Principle
        public static void Main()
        {
            var generator = new InvoiceGenerator();
            var repository = new InvoiceRepository();
            var emailService = new InvoiceEmailService();

            var invoiceService = new InvoiceService(generator, repository, emailService);
            invoiceService.ProcessInvoice();

            Console.WriteLine("Invoice processing complete.");
        }
    }

    public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }

    public class InvoiceGenerator
    {
        public Invoice Generate()
        {
            Console.WriteLine("Generating invoice...");
            return new Invoice { Id = 1, Amount = 199.99m };
        }
    }

    public class InvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Saving invoice {invoice.Id} with amount {invoice.Amount} to database...");
        }
    }

    public class InvoiceEmailService
    {
        public void SendEmail(Invoice invoice)
        {
            Console.WriteLine($"Sending invoice {invoice.Id} via email...");
        }
    }

    public class InvoiceService
    {
        private readonly InvoiceGenerator _generator;
        private readonly InvoiceRepository _repository;
        private readonly InvoiceEmailService _emailService;

        public InvoiceService(
            InvoiceGenerator generator,
            InvoiceRepository repository,
            InvoiceEmailService emailService)
        {
            _generator = generator;
            _repository = repository;
            _emailService = emailService;
        }

        public void ProcessInvoice()
        {
            var invoice = _generator.Generate();
            _repository.Save(invoice);
            _emailService.SendEmail(invoice);
        }
    }
}

