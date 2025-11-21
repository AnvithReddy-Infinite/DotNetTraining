using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.WriteLog("Application started");
            Logger.Instance.WriteLog("Action performed");
        }
    }
}
