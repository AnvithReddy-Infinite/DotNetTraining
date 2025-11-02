using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter light color: ");
            string color = Console.ReadLine().ToLower(); 

            string action = "";

            if (color == "red")
            {
                action = "Stop";
            }
            else if (color == "yellow")
            {
                action = "Get Ready";
            }
            else if (color == "green")
            {
                action = "Go";
            }
            else
            {
                action = "Invalid color";
            }

            Console.WriteLine("Action: " + action);
            Console.ReadLine();

        }
    }
}

