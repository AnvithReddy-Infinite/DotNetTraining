using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount mySavings = new SavingsAccount("SA123", 1000);
            mySavings.Deposit(500);
            mySavings.CalculateInterest();

           

            CurrentAccount currentAccount = new CurrentAccount("CA123", 5000);
            currentAccount.Deposit(1000);
            currentAccount.CalculateInterest();

            
           // BankAccount account = new BankAccount("BA123", 2000); // This line would cause a compile-time error
           PersonalDetails details = new PersonalDetails();
            details.GetPersonalDetails();
            Console.ReadLine();
        }
    }

    
}
