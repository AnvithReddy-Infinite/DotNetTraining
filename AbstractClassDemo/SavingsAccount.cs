using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, double initialBalance)
        : base(accountNumber, initialBalance)
        {
        }
        public override void CalculateInterest()
        {
            double interest = Balance * 0.04; // 4% interest
            Balance += interest;
            Console.WriteLine($"Interest of {interest} added. New balance is {Balance}");
        }
    }
}
