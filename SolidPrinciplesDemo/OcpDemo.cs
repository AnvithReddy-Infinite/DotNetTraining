using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public class OcpDemo
    {
        // OCP: Open/Closed Principle
        public static void Main()
        {
            var discountService = new DiscountService();

            Console.WriteLine("VIP discount: " + discountService.ApplyDiscount("VIP"));
            Console.WriteLine("Employee discount: " + discountService.ApplyDiscount("Employee"));
            Console.WriteLine("Regular discount: " + discountService.ApplyDiscount("Regular"));
        }
    }

    public interface IDiscountStrategy
    {
        decimal GetDiscount();
    }

    public class VipDiscount : IDiscountStrategy
    {
        public decimal GetDiscount() => 0.8m;
    }

    public class EmployeeDiscount : IDiscountStrategy
    {
        public decimal GetDiscount() => 0.5m;
    }

    public class NoDiscount : IDiscountStrategy
    {
        public decimal GetDiscount() => 0m;
    }

    public class DiscountService
    {
        private readonly Dictionary<string, IDiscountStrategy> _strategies;

        public DiscountService()
        {
            _strategies = new Dictionary<string, IDiscountStrategy>
        {
            { "VIP", new VipDiscount() },
            { "Employee", new EmployeeDiscount() }
        };
        }

        public decimal ApplyDiscount(string customerType)
        {
            if (_strategies.TryGetValue(customerType, out var strategy))
                return strategy.GetDiscount();

            return new NoDiscount().GetDiscount();
        }
    }
}
