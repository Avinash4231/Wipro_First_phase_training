using System;

class BankAccount
{
    // Encapsulation: Private fields with public properties
    private string accountHolder;
    private double balance;

    public string AccountHolder
    {
        get { return accountHolder; }
        set { accountHolder = value; }
    }

    public double Balance
    {
        get { return balance; }
    }
public BankAccount(){
    Console.WriteLine("BankAccount constructor called");
}
    // Constructor
    public BankAccount(string holder, double initialBalance)
    {
        accountHolder = holder;
        balance = initialBalance;
    }

    // Virtual method for withdrawal
    public virtual void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"{amount} withdrawn. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount} deposited. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }
}

// Inheritance: SavingsAccount extends BankAccount
class SavingsAccount : BankAccount
{
    private double interestRate;

public SavingsAccount():base(){
    Console.WriteLine("SavingsAccount constructor called");
}
    public SavingsAccount(string holder, double initialBalance, double rate) 
        : base(holder, initialBalance) 
    {
        interestRate = rate;
    }

    // Overriding Withdraw method (Polymorphism)
    public override void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance - 100) // Minimum balance rule
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Withdrawal denied. Minimum balance should be maintained.");
        }
    }

    public void ApplyInterest()
    {
        double interest = Balance * (interestRate / 100);
        Deposit(interest);
        Console.WriteLine($"Interest applied at {interestRate}%. New balance: {Balance}");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // SavingsAccount myAccount = new SavingsAccount("John Doe", 1000, 5);
        // myAccount.Deposit(500);
        // myAccount.Withdraw(300);
        // myAccount.ApplyInterest();

        SavingsAccount myAccount = new SavingsAccount();

    }
}
