using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderManagementDemo
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }

        public Order(int id, string name, decimal amount)
        {
            OrderId = id;
            CustomerName = name;
            TotalAmount = amount;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderId}, Customer: {CustomerName}, Amount: Rs: {TotalAmount}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            ArrayList orderList = new ArrayList();

            // Add sample data
            orderList.Add(new Order(101, "Ramesh", 450.50M));
            orderList.Add(new Order(102, "Nisha", 700.00M));
            orderList.Add(new Order(103, "Ajay", 250.00M));

            while (true)
            {
                Console.WriteLine("\n==== Foodify Order Menu ====");
                Console.WriteLine("1. Add New Order");
                Console.WriteLine("2. Display All Orders");
                Console.WriteLine("3. Search Order by ID");
                Console.WriteLine("4. Remove Order by ID");
                Console.WriteLine("5. Show Total Orders");
                Console.WriteLine("6. Sort Orders by Amount");
                Console.WriteLine("7. Reverse List (Latest First)");
                Console.WriteLine("8. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Order ID: ");
                        int oid = int.Parse(Console.ReadLine());
                        Console.Write("Customer Name: ");
                        string cname = Console.ReadLine();
                        Console.Write("Total Amount: ");
                        decimal amt = decimal.Parse(Console.ReadLine());
                        orderList.Add(new Order(oid, cname, amt));
                        Console.WriteLine("Order added!");
                        break;

                    case 2:
                        Console.WriteLine("\nCurrent Orders:");
                        foreach (Order o in orderList)
                            Console.WriteLine(o);
                        break;

                    case 3:
                        Console.Write("Enter Order ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        bool found = false;
                        foreach (Order o in orderList)
                        {
                            if (o.OrderId == searchId)
                            {
                                Console.WriteLine("Found: " + o);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                            Console.WriteLine("Order not found.");
                        break;

                    case 4:
                        Console.Write("Enter Order ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        Order toRemove = null;
                        foreach (Order o in orderList)
                        {
                            if (o.OrderId == removeId)
                            {
                                toRemove = o;
                                break;
                            }
                        }
                        if (toRemove != null)
                        {
                            orderList.Remove(toRemove);
                            Console.WriteLine("Order removed.");
                        }
                        else
                        {
                            Console.WriteLine("Order not found.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Total Orders: " + orderList.Count);
                        break;

                    case 6:
                        orderList.Sort(new AmountComparer());
                        Console.WriteLine("Sorted by Amount.");
                        foreach (Order o in orderList)
                            Console.WriteLine(o);
                        break;

                    case 7:
                        orderList.Reverse();
                        Console.WriteLine("List reversed. Latest orders first:");
                        foreach (Order o in orderList)
                            Console.WriteLine(o);
                        break;

                    case 8:
                        Console.WriteLine("Exiting. Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again!");
                        break;
                }
            }
        }

        class AmountComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                Order a = (Order)x;
                Order b = (Order)y;
                return a.TotalAmount.CompareTo(b.TotalAmount);
            }
        }
    }
}
