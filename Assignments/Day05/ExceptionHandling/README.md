# C# Exception Handling Case Study

## Problem Statement
Build a simple banking transaction system that supports deposit, withdrawal, and balance check operations while enforcing business rules through exception handling.

## Business Rules
- Minimum balance must remain `Rs. 1000`
- Withdrawal amount cannot exceed the available balance
- Deposit amount must be greater than `0`
- Invalid operations should be handled without crashing the program

## Exception Types Used
- `ArgumentException`
- `InvalidOperationException`
- `InvalidAmountException` (custom)
- `InsufficientBalanceException` (custom)

## Sample Output
```text
Banking Transaction System
Account Holder : Aarav Sharma
Opening Balance: Rs. 5,000.00

Transaction: Deposit Rs. 2000
Deposit successful. Updated balance: Rs. 7,000.00
Transaction completed.
```

## How to Run the Code
1. Open a terminal in the project folder.
2. Run `dotnet run`.

## Files Included
- `Program.cs`
- `ExceptionHandling.csproj`
