using System;

class Account
{
    // Define properties
    // Complete Step 1:............
    public string AccountNumber;
    public string OwnerName;
    private decimal Balance;

    public Account (string accNumber, string ownername){
        AccountNumber = accNumber;
        OwnerName = ownername;
        Balance = 0;
    }

    // Define methods
    // Complete Step 2:............
    public void Deposit (decimal amt) {
        Balance+=amt;
        Console.WriteLine("Deposited: $"+amt.ToString("F2"));
    }

    public void Withdraw (decimal amt) {
        Balance-=amt;
        Console.WriteLine("Withdrew: $"+amt.ToString("F2"));
    }
    public void ShowBalance() {
        Console.WriteLine("Account Balance: $"+Balance.ToString("F2"));
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter account details
        Console.WriteLine("Enter account number:");
        // Complete Step 3:............
        string accNumber=Console.ReadLine();

        Console.WriteLine("Enter owner name:");
        // Complete Step 4:............
        string ownerName=Console.ReadLine();

        // Create an instance of the Account class
        // Complete Step 5:............
        Account acc = new Account (accNumber, ownerName);

        // Perform transactions
        // Complete Step 6:............
        acc.Deposit(100);
        acc.ShowBalance();

        acc.Withdraw(50);
        acc.ShowBalance();
    }
}