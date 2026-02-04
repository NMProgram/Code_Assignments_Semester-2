static class TestFunctionality
{
    public static void TestFrequencies(int timesToRoll)
    {
        for (int i = 0; i < timesToRoll; i++)
        {
            GameTools.RollAndTrackD4();
            GameTools.RollAndTrackD6();
            GameTools.RollAndTrackD8();
            GameTools.RollAndTrackD10();
            GameTools.RollAndTrackD12();
            GameTools.RollAndTrackD20();
        }

        foreach (int sides in new[] { 4, 6, 8, 10, 12, 20 })
        {
            PrintDiceFrequencies(GameTools.DiceFrequencies[sides], sides);
            Console.WriteLine();
        }
    }

    private static void PrintDiceFrequencies(Dictionary<int, int> frequencies, int sides)
    {
        Console.WriteLine($"Sides: {sides}");

        for (int i = 1; i <= sides; i++) // Loop through all possible sides of the die
        {
            int count = frequencies.ContainsKey(i) ? frequencies[i] : 0;
            Console.WriteLine($" - Side {i} RollAndTracked {count} times");
        }
    }

    public static void TestD20WithAdvantage()
    {
        Console.WriteLine("Rolling D20s with advantage:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($" - {GameTools.RollAndTrackD20WithAdvantage()}");
        }
    }

    public static void TestD20WithDisadvantage()
    {
        Console.WriteLine("Rolling D20s with disadvantage:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($" - {GameTools.RollAndTrackD20WithDisadvantage()}");
        }
    }
}
