using System;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("Abhishek", 5000);

        try
        {
            account.Deposit(2000);
            account.Withdraw(7000); // Will trigger exception
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine("Invalid Amount Error: " + ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Balance Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }

        account.CheckBalance();
    }
}