/*
User Story

As a banking application developer, I want to manage transactions and account operations so
that users can perform secure and traceable financial activities.
Problem Statement
Develop a transaction processing system.

Requirements

Use List<Transaction> for transaction history
Use Dictionary<string, double> for account balances
Use Queue<Transaction> for pending transactions
Use Stack<Transaction> for rollback operations
Use HashSet<string> to ensure unique transaction IDs

Custom Object Example

class Transaction {
public string TransactionId;
public double Amount;
}

Expected Outcome

Process transactions securely
Prevent duplicate transactions
Support rollback functionality
*/

using System;
using System.Collections.Generic;

class Transaction
{
    public string TransactionId { get; set; }
    public double Amount { get; set; }
}

class Program
{
    static void Main()
    {
        List<Transaction> history = new List<Transaction>();
        Dictionary<string, double> accountBalances = new Dictionary<string, double>();
        Queue<Transaction> pendingTransactions = new Queue<Transaction>();
        Stack<Transaction> rollback = new Stack<Transaction>();
        HashSet<string> transactionIds = new HashSet<string>();

        accountBalances["Account1"] = 1000.0;

        Transaction transaction1 = new Transaction { TransactionId = "T1", Amount = 200.0 };
        if (transactionIds.Add(transaction1.TransactionId))
        {
            pendingTransactions.Enqueue(transaction1);
        }

        //Process
        Transaction currentTransaction = pendingTransactions.Dequeue();
        accountBalances["Account1"] -= currentTransaction.Amount;
        history.Add(currentTransaction);
        rollback.Push(currentTransaction);

        Console.WriteLine($"Processed Transaction: {currentTransaction.TransactionId}, New Balance: {accountBalances["Account1"]}");

        //Rollback
        Transaction lastTransaction = rollback.Pop();
        accountBalances["Account1"] += lastTransaction.Amount;
        Console.WriteLine($"Rolled Back Transaction: {lastTransaction.TransactionId}, Restored Balance: {accountBalances["Account1"]}");
    }
}