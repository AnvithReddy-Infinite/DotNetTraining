using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    interface Iservice
    {
        void Add(int x, int y);
    }

    // service class
    class service : Iservice
    {

        public void Add(int x, int y)
        {
            Console.WriteLine($"the sum is {x + y}");
        }
    }


    internal class Mathcls
    {
        // constructor , properties , methods

        // Iservice ob;// null
        //public Mathcls(Iservice s)// null
        //{
        //    ob = s;
        //}

        public Iservice GetInstance { get; set; }
        public void show(Iservice s)
        {
            //  ob.Add(10, 20);
            // GetInstance.Add(10, 20);
            s.Add(10, 20);
        }

    }
}
