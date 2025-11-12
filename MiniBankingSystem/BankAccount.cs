using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankingSystem
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolder { get; }
        public decimal Balance { get; }

        public BankAccount(string accNo, string holder, decimal balance)
        {
            AccountNumber = accNo;
            AccountHolder = holder;
            Balance = balance;
        }

        // + operator: Deposit (combine balances into new account)
        public static BankAccount operator +(BankAccount a, BankAccount b)
        {
            return new BankAccount(
                a.AccountNumber + "+" + b.AccountNumber,
                a.AccountHolder + " & " + b.AccountHolder,
                a.Balance + b.Balance
            );
        }

        // - operator: Withdraw
        public static BankAccount operator -(BankAccount a, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return a;
            }
            if (a.Balance - amount < 0)
            {
                Console.WriteLine("Insufficient balance. Withdrawal denied.");
                return a;
            }
            return new BankAccount(a.AccountNumber, a.AccountHolder, a.Balance - amount);
        }

        // == and != operators: Compare balances
        public static bool operator ==(BankAccount a, BankAccount b)
        {
            if (ReferenceEquals(a, b)) return true;
            if ((object)a == null || (object)b == null) return false;
            return a.Balance == b.Balance;
        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {
            return !(a == b);
        }

        // > and < operators: Compare balances
        public static bool operator >(BankAccount a, BankAccount b)
        {
            return a.Balance > b.Balance;
        }

        public static bool operator <(BankAccount a, BankAccount b)
        {
            return a.Balance < b.Balance;
        }

        // Required for ==/!= to work properly
        public override bool Equals(object obj)
        {
            if (obj is BankAccount other)
                return this.Balance == other.Balance;
            return false;
        }

        public override int GetHashCode()
        {
            return this.Balance.GetHashCode();
        }

        // ToString method override
        public override string ToString()
        {
            return $"Account Holder: {AccountHolder}, Account Number: {AccountNumber}, Balance: Rs: {Balance}";
        }
    }
}
