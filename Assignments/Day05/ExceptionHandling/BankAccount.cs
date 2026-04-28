using System;

public class BankAccount
{
    public string AccountHolderName { get; set; }
    public double Balance { get; private set; }

    public BankAccount(string name, double initialBalance)
    {
        AccountHolderName = name;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new InvalidAmountException("Deposit amount must be greater than 0.");

        Balance += amount;
        Console.WriteLine($"Deposited: ₹{amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new InvalidAmountException("Withdrawal amount must be greater than 0.");

        if (amount > Balance)
            throw new InsufficientBalanceException("Withdrawal exceeds available balance.");

        if ((Balance - amount) < 1000)
            throw new InsufficientBalanceException("Minimum balance of ₹1000 must be maintained.");

        Balance -= amount;
        Console.WriteLine($"Withdrawn: ₹{amount}");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: ₹{Balance}");
    }
}