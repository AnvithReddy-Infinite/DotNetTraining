using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_24_Nov
{
    internal class Assignment_Banking
    {
        public class BankAccount
        {
            public decimal Balance { get; private set; }
            public List<string> History { get; private set; } = new List<string>();

            public BankAccount(decimal openingBalance)
            {
                Balance = openingBalance;
            }

            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Amount must be positive");
                Balance += amount;
                History.Add($"Deposit {amount}");
            }

            public void Withdraw(decimal amount)
            {
                if (amount > Balance)
                    throw new InvalidOperationException("Insufficient funds");
                Balance -= amount;
            }

            public void ApplyInterest(decimal rate)
            {
                Balance += Balance * rate;
            }
        }

    }
}
