using MultipleInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    interface Product
    {
        void GetProductInfo();
        void DisplayProductInfo();
    }
    interface Review
    {
        void GetReviews();
        void DisplayReviews();



    }
    public class Customer : Product, Review
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int ReviewId { get; set; } = 0;
        public string Comments { get; set; }
        public int Ratings { get; set; }
        public int CustomerProductId { get; set; }
        public void GetProductInfo()
        {
            Console.WriteLine("Enter the ProductId,Name,Price");
            ProductId = Convert.ToInt32(Console.ReadLine());
            ProductName = Console.ReadLine();
            Price = Convert.ToDouble(Console.ReadLine());

        }
        public void DisplayProductInfo()
        {
            Console.WriteLine("ProductId: " + ProductId);
            Console.WriteLine("ProductName: " + ProductName);
            Console.WriteLine("Price: " + Price);
        }
        public void GetReviews()
        {
            Console.WriteLine("Enter the ProductId,Comments,Rating(1-5)");
            ProductId = Convert.ToInt32(Console.ReadLine());
            Comments = Console.ReadLine();
            Ratings = Convert.ToInt32(Console.ReadLine());
            ReviewId++;
        }
        public void DisplayReviews()
        {
            Console.WriteLine("ReviewId: " + ReviewId);
            Console.WriteLine("ProductId: " + ProductId);
            Console.WriteLine("Comments: " + Comments);
            Console.WriteLine("Ratings: " + Ratings);
        }

    }
}


