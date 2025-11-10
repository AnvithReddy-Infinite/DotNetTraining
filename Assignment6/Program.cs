using System;

// Interface for all gateways (no method bodies)
public interface IPaymentGateway
{
    bool MakePayment(decimal amount, string payee);
    void LogOperation(string message);
}

// Credit Card gateway
public class CreditCardGateway : IPaymentGateway
{
    public bool MakePayment(decimal amount, string payee)
    {
        LogOperation("Credit Card payment started for " + payee + " of ₹" + amount);
        Console.WriteLine("Processing Credit Card payment of ₹{0} for {1}", amount, payee);
        LogOperation("Credit Card payment completed for " + payee);
        return true;
    }
    public void LogOperation(string message)
    {
        Console.WriteLine("[CreditCard] " + message);
    }
}

// UPI gateway
public class UpiGateway : IPaymentGateway
{
    public bool MakePayment(decimal amount, string payee)
    {
        LogOperation("UPI payment started for " + payee + " of ₹" + amount);
        Console.WriteLine("Processing UPI payment of ₹{0} for {1}", amount, payee);
        LogOperation("UPI payment completed for " + payee);
        return true;
    }
    public void LogOperation(string message)
    {
        Console.WriteLine("[UPI] " + message);
    }
}

// Wallet gateway
public class WalletGateway : IPaymentGateway
{
    public bool MakePayment(decimal amount, string payee)
    {
        LogOperation("Wallet payment started for " + payee + " of ₹" + amount);
        Console.WriteLine("Processing Wallet payment of ₹{0} for {1}", amount, payee);
        LogOperation("Wallet payment completed for " + payee);
        return true;
    }
    public void LogOperation(string message)
    {
        Console.WriteLine("[Wallet] " + message);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Smart Payment Gateway ===");
        IPaymentGateway gateway = null;

        Console.WriteLine("Select Payment Type: 1. Credit Card 2. UPI 3. Wallet");
        int type = Convert.ToInt32(Console.ReadLine());

        switch (type)
        {
            case 1: gateway = new CreditCardGateway(); break;
            case 2: gateway = new UpiGateway(); break;
            case 3: gateway = new WalletGateway(); break;
            default:
                Console.WriteLine("Invalid type. Using Wallet by default.");
                gateway = new WalletGateway();
                break;
        }

        Console.Write("Enter recipient name: ");
        string payee = Console.ReadLine();

        Console.Write("Enter payment amount: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        bool success = gateway.MakePayment(amount, payee);

        Console.WriteLine(success ? "Payment Successful!" : "Payment Failed!");
    }
}
