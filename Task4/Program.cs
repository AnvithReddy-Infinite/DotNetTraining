using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Ask the user to enter a password
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Step 2: Check the length of the password
            int length = password.Length;
            string strength = "";

            if (length < 6)
            {
                strength = "Weak";
            }
            else if (length <= 10)
            {
                strength = "Medium";
            }
            else
            {
                strength = "Strong";
            }

            // Step 3: Display the strength
            Console.WriteLine("Password strength: " + strength);
            Console.ReadLine();

        }
    }
}
