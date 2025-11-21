using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class PredefinedInterfacesDemo
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList() { "Apple", "Banana", "Mango", "Orange", "Grapes"};  
            IEnumerator enumerator = items.GetEnumerator();
            Console.WriteLine(");
        }
    }
}
