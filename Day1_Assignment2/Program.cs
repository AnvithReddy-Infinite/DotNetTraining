using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assignment2
{
    internal class Program
    {
        // Assignment 3: Factorial method
        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            return fact;
        }

        // assignement 1, 2, 3
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                    Console.WriteLine(i);
            });

            Task t2 = Task.Run(() =>
            {
                for (int i = 6; i <= 10; i++)
                    Console.WriteLine(i);
            });

            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("All numbers printed!");
            });

            Task.WaitAll(t1, t2, t3); // Waits for all three tasks to finish
            Console.WriteLine("\nDone \n");




            // Assignment 2:
            Random rnd = new Random();
            Task<int> T1 = Task.Run(() => rnd.Next(1, 100));
            Task<int> T2 = Task.Run(() => rnd.Next(1, 100));
            Task<int> T3 = Task.Run(() => rnd.Next(1, 100));

            Task.WhenAll(T1, T2, T3).ContinueWith(T =>
            {
                int sum = T1.Result + T2.Result + T3.Result;
                Console.WriteLine($"Randoms: {T1.Result}, {T2.Result}, {T3.Result}");
                Console.WriteLine($"Sum: {sum} \n ");
            }).Wait(); // Waits for sum print to finish


            // Assignment 3: Factorial
            int num = 7; // Change to any number you like!
            Task<int> t = Task.Run(() => Factorial(num));
            Console.WriteLine($"Factorial of {num}: {t.Result}");
        }
    }
}
