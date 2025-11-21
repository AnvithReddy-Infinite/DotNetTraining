using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class ProductInfo
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }

    }
    public class SortByAscending : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
    public class SortByName : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class SortByRating : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Rating.CompareTo(y.Rating);
        }
    }
    public class SortByDescending : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return y.Price.CompareTo(x.Price);
        }
    }
    internal class IComparerInterfaceDemo
    {
        public static void Main(string[] args)
        {
            List<ProductInfo> list = new List<ProductInfo>();
            list.Add(new ProductInfo { ProductId = 101, Name = "Laptop", Price = 50000, Rating = 4.3m });
            list.Add(new ProductInfo { ProductId = 103, Name = "Mobile", Price = 27000, Rating = 4.7m });
            list.Add(new ProductInfo { ProductId = 102, Name = "Fridge", Price = 22000, Rating = 4.1m });
            list.Add(new ProductInfo { ProductId = 104, Name = "TV", Price = 32000, Rating = 3.9m });

            Console.WriteLine("1. Sort the Price Ascending Order");
            list.Sort(new SortByAscending());
            DisplayProducts(list);

            Console.WriteLine("1. Sort the Price Descending Order");
            list.Sort(new SortByDescending());
            DisplayProducts(list);

            Console.WriteLine("1. Sort by name");
            list.Sort(new SortByName());
            DisplayProducts(list);

            Console.WriteLine("1. Sort by rating");
            list.Sort(new SortByRating());
            DisplayProducts(list);


        }
        static void DisplayProducts(List<ProductInfo> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.Name}, ProductPrice: {product.Price}, ProductRating: {product.Rating}");
            }
        }
    }
}

