using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export
{
    public abstract class DataExporter
    {
        public void Export()
        {
            Connect();
            Fetch();
            Format();
            Save();
        }

        protected virtual void Connect()
        {
            Console.WriteLine("Connecting to data source...");
        }
        protected abstract void Fetch();
        protected abstract void Format();
        protected virtual void Save()
        {
            Console.WriteLine("Saving to file...");
        }
    }
}
