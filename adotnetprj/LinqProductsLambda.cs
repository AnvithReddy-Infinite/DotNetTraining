using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adotnetprj
{
    internal class LinqProductsLambda
    {
        public class Products
        {
            public int pid { get; set; }
            public string pname { get; set; }
            public int price { get; set; }
            public int qty { get; set; }
        }


        private List<Products> li = new List<Products>()
        {
            new Products() { pid = 100, pname = "book", price = 1000, qty = 5 },
            new Products() { pid = 200, pname = "cd", price = 2000, qty = 6 },
            new Products() { pid = 300, pname = "toys", price = 3000, qty = 5 },
            new Products() { pid = 400, pname = "mobile", price = 8000, qty = 6 },
            new Products() { pid = 600, pname = "pen", price = 200, qty = 7 },
            new Products() { pid = 700, pname = "tv", price = 30000, qty = 7 },
        };

        // 1. find second highest price
        public void SecondHighestPrice()
        {
            var second = li.Select(p => p.price).Distinct().OrderByDescending(x => x).Skip(1).FirstOrDefault();
            Console.WriteLine("1) Second highest price: " + second);
        }

        // 2. display top 3 highest price
        public void Top3Highest()
        {
            var top3 = li.OrderByDescending(p => p.price).Take(3);
            Console.WriteLine("2) Top 3 highest priced products:");
            foreach (var p in top3) Console.WriteLine($"{p.pname}  {p.price}");
        }

        // 3. find the sum of price where product names contains letter 'O'
        public void SumPriceContainsO()
        {
            var sum = li
                .Where(p => !string.IsNullOrEmpty(p.pname) && p.pname.ToLower().Contains("o"))
                .Sum(p => p.price);

            Console.WriteLine("3) Sum of price where product name contains letter 'O': " + sum);
        }


        // 4. find the product name ends with e and display only pid and pname (filter by column name)
        public void ProductsEndingWithE()
        {
            var res = li.Where(p => p.pname.EndsWith("e", StringComparison.OrdinalIgnoreCase)).Select(p => new { p.pid, p.pname });
            Console.WriteLine("4) Products ending with 'e' (pid - pname):");
            foreach (var x in res) Console.WriteLine($"{x.pid}   {x.pname}");
        }

        // 5. group all records by qty find max of price
        public void GroupByQtyMaxPrice()
        {
            var grp = li.GroupBy(p => p.qty).Select(g => new { Qty = g.Key, MaxPrice = g.Max(p => p.price) }).OrderBy(g => g.Qty);
            Console.WriteLine("5) Max price per qty group:");
            foreach (var g in grp) Console.WriteLine($"Qty: {g.Qty}   MaxPrice: {g.MaxPrice}");
        }

        // 6. product with minimum price
        public void MinPriceProduct()
        {
            var min = li.OrderBy(p => p.price).FirstOrDefault();
            if (min != null)
                Console.WriteLine($"6) Product with minimum price: {min.pname}  {min.price}");
            else
                Console.WriteLine("6) No products available.");
        }

        // 7. average price of all products
        public void AveragePrice()
        {
            var avg = li.Average(p => p.price);
            Console.WriteLine($"7) Average price of all products: {avg:F2}");
        }

        public void RunAll()
        {
            SecondHighestPrice();
            Console.WriteLine();
            Top3Highest();
            Console.WriteLine();
            SumPriceContainsO();
            Console.WriteLine();
            ProductsEndingWithE();
            Console.WriteLine();
            GroupByQtyMaxPrice();
            Console.WriteLine();
            MinPriceProduct();
            Console.WriteLine();
            AveragePrice();
        }
    }
}

