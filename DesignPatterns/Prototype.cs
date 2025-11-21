using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Class1
    {
        public int p2 { get; set; }

        public int p1 { get; set; }

        public object Clone()
        {//copies all data to second object
            return this.MemberwiseClone(); // Shallow copy
        }
    }
}
