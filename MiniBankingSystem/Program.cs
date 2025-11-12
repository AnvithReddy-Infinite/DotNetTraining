using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acct1 = new BankAccount("AC101", "Ramesh Kumar", 25000);
            BankAccount acct2 = new BankAccount("AC102", "Suresh Nair", 40000);

            Console.WriteLine(acct1);
            Console.WriteLine(acct2);

            Console.WriteLine("\nMerging accounts (using +):");
            BankAccount mergedAccount = acct1 + acct2;
            Console.WriteLine($"Combined Balance: Rs: {mergedAccount.Balance}");

            Console.WriteLine("\nComparing balances:");
            Console.WriteLine($"AC101 < AC102 --> {acct1 < acct2}");
            Console.WriteLine($"AC101 == AC102 --> {acct1 == acct2}");

            Console.WriteLine("\nWithdrawal operation (using -):");
            BankAccount afterWithdrawal = acct1 - 5000;
            Console.WriteLine($"New Balance of Ramesh: Rs:{afterWithdrawal.Balance}");

            // Edge: Try to overdraw
            BankAccount failWithdrawal = acct1 - 999999;
            Console.WriteLine($"Attempted overdraft: Rs: {failWithdrawal.Balance}");
        }
    }
}
