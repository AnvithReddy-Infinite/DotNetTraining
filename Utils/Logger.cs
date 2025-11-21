using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Logger
    {
        private static Logger _instance;
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Logger();
                return _instance;
            }
        }

        public void WriteLog(string message)
        {
            // Writes to console for demo, to file in real app
            Console.WriteLine($"Log: {message}");
            // For file: System.IO.File.AppendAllText("log.txt", message + "\n");
        }

    }
}
