using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Initial Capacity" + arrayList.Capacity);
            arrayList.Add(10);
            Console.WriteLine("Capacity after adding First Item:" + arrayList.Capacity);
            arrayList.Add("Test Item 1");
            arrayList.Add(true);
            arrayList.Add(15.5);
            Console.WriteLine("Capacity after adding Four Items:" + arrayList.Capacity);
            Console.WriteLine("\n Items in ArrayList is ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Remove(true);
            Console.WriteLine("After removing true arrayList items are");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after removing true capacity" + arrayList.Capacity);
            arrayList.Add("Anvith");
            arrayList.Add("Reddy");
            arrayList.Add("Gaddam");
            arrayList.Insert(1, "New Item at Index 1");
            Console.WriteLine("After adding 7 values capacity" + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

           

            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add("First Item in ArrayList2");
            arrayList2.Add("Second Item in ArrayList2");
            arrayList.AddRange(arrayList2);

            Console.WriteLine("after Adding 9 values capacity" + arrayList.Capacity);

            ArrayList deptList = new ArrayList() { "IT", "HR", "Admin", "Finance" };
            arrayList.InsertRange(2, deptList);
            Console.WriteLine("After inserted DeptList in the index position 2 in arraylist");
            foreach (var item in arrayList)
            { 
            Console.WriteLine(item);
            }
            Console.WriteLine("after Adding 13 values capacity" + arrayList.Capacity);
            Console.WriteLine($" HR is there in arrayList or not? {arrayList.Contains("HRM")}");
            Console.WriteLine("Total Count" + arrayList.Count);
            Console.WriteLine($"arrayList[4] : {arrayList[4]}");

            //GetRange
            ArrayList arrayList3 = arrayList.GetRange(3, 5);
            Console.WriteLine(" arrayList3 values are");
            arrayList3.Reverse();
            arrayList3.RemoveRange(2, 2);
            arrayList3.Sort();
            arrayList3.RemoveAt(0);
            foreach (var item in arrayList3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();




        }
    }
}
