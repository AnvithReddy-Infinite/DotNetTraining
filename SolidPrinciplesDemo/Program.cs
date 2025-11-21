using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // injector code

            //Mathcls ob = new Mathcls(new service());
            // constructor injection
            Mathcls ob = new Mathcls();
            //ob.GetInstance = new service();// property injection
            ob.show(new service());// method injection
        }
        
    }
}
