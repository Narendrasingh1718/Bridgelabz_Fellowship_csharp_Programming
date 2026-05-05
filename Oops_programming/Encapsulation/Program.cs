using System;
using System.Diagnostics.Metrics;
class Program
{
    static void Main(string[] args)
    {
        // Create a new bank account with an initial balance
        Bank account = new Bank("123456789", 500.0);
        // Display account information
        account.DisplayAccountInfo();
        // Deposit money
        account.Deposit(150.0);
        account.DisplayAccountInfo();
        // Withdraw money
        account.Withdraw(100.0);
        account.DisplayAccountInfo();
        // Try to set an invalid balance directly (will not compile)
        // account.Balance = -100; // Error: 'Balance' has a private
        account.Deposit(-50);
        account.Withdraw(1000);
    }
}