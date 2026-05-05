using System;
public class Bank
{
    // Private fields - data encapsulation
    private string accountNumber;
    private double balance;
    // Constructor
    public Bank(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        Balance = initialBalance; // Using property for validation

    }
    // Public getter for accountNumber (read-only)
    public string AccountNumber
    {
        get { return accountNumber; }
    }
    // Public property for balance with validation
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("Balance cannot be negative.");

        }
    }
    // Method to deposit money with encapsulation
    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
        else
            Console.WriteLine("Deposit amount must be positive.");

    }
    
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Invalid withdraw amount.");

    }
    public void DisplayAccountInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Current Balance: " + balance);
    }
}