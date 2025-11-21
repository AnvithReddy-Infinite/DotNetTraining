using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataExporter csv = new CsvExporter();
            DataExporter json = new JsonExporter();
            DataExporter xml = new XmlExporter();

            Console.WriteLine("CSV export:");
            csv.Export();

            Console.WriteLine("\nJSON export:");
            json.Export();

            Console.WriteLine("\nXML export:");
            xml.Export();
        }
    }
}
