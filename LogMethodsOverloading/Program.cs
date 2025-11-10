using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMethodsOverloading
{
    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"the Information is {message}");
        }
        public void Log(string message, int level)
        {
            Console.WriteLine($"the Information is about {message} and attention level is {level}");
        }
        public void Log(string message, DateTime time)
        {
            Console.WriteLine($"The time is {time} :  Information is about {message}");
        }
        public void Log(string message, int level, DateTime time)
        {
            Console.WriteLine($"The time is {time} : Information is about {message} and the attention level is {level}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log("Event is getting started, Hurry Up!....");
            logger.Log("Event", 5);
            logger.Log("Event", DateTime.Now);
            logger.Log("Event", 6, DateTime.Now);

        }
    }
}
