using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export
{
    public class CsvExporter : DataExporter
    {
        protected override void Fetch() { Console.WriteLine("Fetching data for CSV..."); }
        protected override void Format() { Console.WriteLine("Formatting as CSV..."); }
        protected override void Save() { Console.WriteLine("Saved as file.csv"); }
    }
}
