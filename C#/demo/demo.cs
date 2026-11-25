using System;

class BankAccount
{
    // Fields
    public string name;
    private int balance;

    // Constructor
    public BankAccount(string n, int b)
    {
        name = n;
        balance = b;
    }

    // Method with void
    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Method with return
    public int GetBalance()
    {
        return balance;
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        BankAccount account =
            new BankAccount("Ram", 5000);

        account.Deposit(2000);

        Console.WriteLine(account.name);
        Console.WriteLine(account.GetBalance());
    }
}