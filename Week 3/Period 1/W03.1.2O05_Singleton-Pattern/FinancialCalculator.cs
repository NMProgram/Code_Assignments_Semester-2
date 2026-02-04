class FinancialCalculator
{
    private static FinancialCalculator? _instance;
    public readonly Dictionary<string, int> Cache;
    private FinancialCalculator()
    {
        _instance = null;
        Cache = [];
    }
    public static FinancialCalculator GetInstance()
    {
        if (_instance is not null) { return _instance; }
        else { _instance = new(); return _instance; }
    }
    public void Reset() => Cache.Clear();
    public int CalculateYearsToReachTarget(decimal currentBalance, decimal yearlyDeposit, decimal target)
    {
        decimal yearlyInterestRate = SavingsAccount.YearlyInterestRate;
        string cacheKey = $"{currentBalance}-{yearlyDeposit}-{target}-{yearlyInterestRate}";
        if (Cache.TryGetValue(cacheKey, out int value)) { return Cache[cacheKey]; }
        int years = 0;
        while (currentBalance < target)
        {
            currentBalance += yearlyDeposit;
            currentBalance *= (1 + yearlyInterestRate);
            years++;
        }
        Cache[cacheKey] = years;
        return years;
    }

    public decimal CalculateYearlyDepositToReachTarget(decimal currentBalance, decimal target, int years)
    {
        decimal remaining = target - currentBalance;

        for (int i = 0; i < years; i++)
        {
            remaining /= (1 + SavingsAccount.YearlyInterestRate);
        }
        
        decimal deposit = remaining / years;
        return deposit;
    }
}
