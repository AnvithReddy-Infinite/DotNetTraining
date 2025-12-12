using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adotnetprj
{
    class arrays

    {
        List<int> listA = new List<int> { 10, 20, 30, 40, 50, 20, 30 };

        List<int> listB = new List<int> { 30, 40, 50, 60, 70, 40 };

        List<string> names1 = new List<string> { "Akshay", "Aasritha", "Deepa", "Kiran","Kiran" };

        List<string> names2 = new List<string> { "Kiran", "Manikanta", "Deepa", "Naveen"

        };

        public void show3()

        {
            //Q1.Write a LINQ query to fetch unique values from listA.
            var res1 = listA.Distinct();
            Console.WriteLine("\n 1) unique values \n");
            foreach (var r1 in res1)
            {
                Console.WriteLine(r1);
            }

            // Q2.Combine values from listA and listB without duplicate
            var res2 = listA.Union(listB);
            Console.WriteLine("\n 2) Combined values without duplicates: \n");
            foreach (var r2 in res2)
            {
                Console.WriteLine(r2);
            }

            //Q3.Find items common in listA and listB.
            var res3 = listA.Intersect(listB);
            Console.WriteLine("\n 3) Common values : \n");
            foreach (var r3 in res3)
            {
                Console.WriteLine(r3);
            }

            // Q4.Find names present in names1 but not in names2
            var res4 = names1.Except(names2);
            Console.WriteLine("\n 4) Present in names1 but not in names2 \n");
            foreach (var r4 in res4)
            {
                Console.WriteLine(r4);
            }

            //Q7.Find the highest value in listA.
            var res7 = listA.Max();
            Console.WriteLine("\n 7) The max value in listA is \n" + res7);

            // Q8.Write a LINQ query to find numbers divisible by 3
            int[] numbers = { 1, 4, 9, 16, 25, 36 };
            var res8 = numbers.Where(n => n % 3 == 0);
            Console.WriteLine("\n 8) They are divisible by 3 \n");
            foreach (var r8 in res8)
            {
                Console.WriteLine(r8);
            }

            //9.Write a Linq to query to sort based on string Length
            string[] st = { "India", "Srilanka", "canada", "Singapore" };
            var res9 = st.OrderBy(s => s.Length);
            Console.WriteLine("\n 9) Sorted by len \n");
            foreach (var r9 in res9)

            {
                Console.WriteLine(r9);
            }

        }

    }
}
