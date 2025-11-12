using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Anvith");
            ht.Add(2, "Keerthana");
            ht.Add("eid", 109);
            ht.Add("dept", "IT");
            ht.Add("location", "Hyderabad");
            ht["email"] = "sample@mail.com";
            ht[56] = "Test Value";

            Console.WriteLine(" Hash table values are");

            Console.WriteLine(" First Value :" + ht[1]);
            Console.WriteLine(" Count of Hash Table : " + ht.Count);
            Console.WriteLine(" The Key 56 is Available or not : " + ht.ContainsKey(56));
            Console.WriteLine(" The Value sample@mail.com is Available or not : " + ht.ContainsValue(56));
            
            ht.Remove(2);
            Console.WriteLine(" \n  After removing Key 2 ,Count of Hash Table : " + ht.Count);
            foreach (DictionaryEntry item in ht.Keys)
            {
                Console.WriteLine(" Key : " + item + " Value : " + ht[item]);
            }


            Console.ReadLine();
        }
    }
}
