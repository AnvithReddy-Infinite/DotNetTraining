using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {
            //SortedList<int, string> products = new SortedList<int, string>();
            //products.Add(101, "laptop");
            //products.Add(102, "mobile");
            //products.Add(103, "tab");
            //products.Add(104, "monitor");
            //foreach (var item in products)
            //{
            //    Console.WriteLine("key: " + item.Key + "value :" + item.Value);
            //}

            SortedList<int, string> inventory = new SortedList<int, string>();
            inventory.Add(2001, "Wheat -50Kg");
            inventory.Add(2003, "Rice - 25Kg");
            inventory.Add(2002, "Sugar - 10Kg");
            inventory.Add(2004, "Salt - 5Kg");
            inventory.Add(2005, "Oil - 1Ltr");
            inventory.Add(2006, "Dal - 2Kg");

            Console.WriteLine("\n Inventory Details:");
            Console.WriteLine(" First Ttem Code " + inventory.Keys[0]);
            Console.WriteLine(" Last Item Code " + inventory.Values[inventory.Count - 1]);
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }
            //Search By Key
            Console.WriteLine("Enter the key to search");
            int keyToSearch = Convert.ToInt32(Console.ReadLine());
            if (inventory.ContainsKey(keyToSearch))
            {
                Console.WriteLine("Item Found: " + inventory[keyToSearch]);
            }
            else
            {
                Console.WriteLine("Item Not Found");
            }

            //search by value
            Console.WriteLine("Enter the value to search");
            string valueToSearch = Console.ReadLine();
            if (inventory.ContainsValue(valueToSearch))
            {
                Console.WriteLine("Item Found with Key: " + inventory.IndexOfValue(valueToSearch));
            }
            else
            {
                Console.WriteLine("Item Not Found in inventory");
            }

            //update Value
            Console.WriteLine("Enter the key to update the value");
            int keyToUpdate = Convert.ToInt32(Console.ReadLine());
            string newValue = Console.ReadLine();
            inventory[keyToUpdate] = newValue;
            Console.WriteLine("Updated Value " + inventory[keyToUpdate]);

            //Remove by Key
            Console.WriteLine("Removing item code 2004");
            inventory.Remove(2004);
            Console.WriteLine("Inventory after removal of 2004");
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            //Remove by Index
            inventory.RemoveAt(0);
            Console.WriteLine("Inventory after removal of index 0");
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            //Get index of Key
            Console.WriteLine("Index of Key 2003: " + inventory.IndexOfKey(2003));
            inventory.Clear();
            Console.ReadLine();


        }
    }
    }
    
