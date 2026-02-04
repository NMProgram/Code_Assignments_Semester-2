class SavingsAccount
{
    public decimal Balance;
    public decimal SavingsTarget;
    public static decimal YearlyInterestRate = 0.05M;

    public SavingsAccount(decimal initialDeposit, decimal savingsTarget)
    {
        Deposit(initialDeposit);
        SavingsTarget = savingsTarget;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException($"{amount}", $"Amount must not be negative: {amount}");
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException($"{amount}", $"Amount must not be negative: {amount}");
        }
        if (amount > Balance)
        {
            throw new ArgumentOutOfRangeException($"{amount}", $"Insufficient balance: {amount} > {Balance}");
        }

        Balance -= amount;
    }

    public void ApplyYearlyInterest() => Balance *= (1 + YearlyInterestRate);
    public bool IsSavingsTargetReached() => Balance >= SavingsTarget;
}
