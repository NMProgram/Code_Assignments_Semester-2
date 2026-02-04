static class TestFunctionality
{
    public static void TestCache()
    {
        var calculator = FinancialCalculator.GetInstance();

        if (calculator.Cache.Count != 0)
        {
            Console.WriteLine("Cache is not empty at the start.");
            return;
        }

        decimal currentBalance = 1000m;
        decimal yearlyDeposit = 200m;
        decimal target = 5000m;

        int years = calculator.CalculateYearsToReachTarget(currentBalance, yearlyDeposit, target);

        string cacheKey = $"{currentBalance}-{yearlyDeposit}-{target}-{SavingsAccount.YearlyInterestRate}";
        if (!calculator.Cache.ContainsKey(cacheKey))
        {
            Console.WriteLine("Cache was not populated correctly.");
            return;
        }

        if (calculator.Cache[cacheKey] != years)
        {
            Console.WriteLine("Cached value does not match the calculated result.");
            return;
        }

        int cachedYears = calculator.CalculateYearsToReachTarget(currentBalance, yearlyDeposit, target);
        if (cachedYears != years)
        {
            Console.WriteLine("Cached result does not match recalculated result.");
            return;
        }

        calculator.Reset();
        if (calculator.Cache.Count != 0)
        {
            Console.WriteLine("Cache was not cleared after reset.");
            return;
        }

        Console.WriteLine("All tests passed!");
    }
}
