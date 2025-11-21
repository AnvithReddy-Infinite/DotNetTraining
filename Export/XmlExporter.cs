using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export
{
    public class XmlExporter : DataExporter
    {
        protected override void Fetch() { Console.WriteLine("Fetching data for XML..."); }
        protected override void Format() { Console.WriteLine("Formatting as XML..."); }
        protected override void Save() { Console.WriteLine("Saved as file.xml"); }
    }
}
