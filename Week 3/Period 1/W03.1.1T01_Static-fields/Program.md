# Overview
This exercise introduces the usage of `static` fields in classes. 
It requires the programmer to make a `BankAccount` class that has a static InterestPercentage 
and another field for the individual Balance of that BankAccount instance.
It also has methods for changing the Balance with a specified value or applying the InterestPercentage to the Balance.

Only the BankAccount class was coded by me, the rest was provided as a template by CodeGrade.

This was very simple (as is expected), but I personally think it fails to explain what the `static` keyword actually does. I had to look that up for myself, 
which I personally think is a dumb way to have a programmer learn the ropes.

# Code
For the BankAccount class, see BankAccount.cs in this directory.
```cs
static class Program
{
    static void Main()
    {
        BankAccount account1 = new();
        BankAccount account2 = new();

        account1.Deposit(1000);
        account2.Deposit(2000);

        BankAccount.InterestPercentage = 10;
        account1.ApplyInterest();

        BankAccount.InterestPercentage = 5;
        account1.ApplyInterest();
        account2.ApplyInterest();

        Console.WriteLine(account1.Balance);
        Console.WriteLine(account2.Balance);
    }
}
```
