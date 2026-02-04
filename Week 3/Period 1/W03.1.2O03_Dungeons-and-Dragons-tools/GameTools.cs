static class GameTools
{
    public static readonly Random Rand = new(0);
    public const int MinRoll = 1;
    public static readonly Dictionary<int, Dictionary<int, int>> DiceFrequencies = new()
    {
        {4, []}, 
        {6, []}, 
        {8, []}, 
        {10, []}, 
        {12, []},
        {20, []},
    };
    public static int RollAndTrackD4() => RollAndTrackDie(4);
    public static int RollAndTrackD6() => RollAndTrackDie(6);
    public static int RollAndTrackD8() => RollAndTrackDie(8);
    public static int RollAndTrackD10() => RollAndTrackDie(10);
    public static int RollAndTrackD12() => RollAndTrackDie(12);
    public static int RollAndTrackD20() => RollAndTrackDie(20);

    public static int RollAndTrackDie(int sides)
    {
        switch (sides % 2)
        {
            case 1 or (> 12 and < 20):
                throw new ArgumentOutOfRangeException($"{sides}", "Invalid amount of sides for dice.");
        }
        int rng = Rand.Next(MinRoll, sides + 1);
        Dictionary<int, int> diceValues = DiceFrequencies[sides];
        diceValues[rng] = (diceValues.GetValueOrDefault(rng) != 0) ? diceValues[rng] + 1 : 1;
        return rng;
    }
    public static int RollAndTrackD20WithAdvantage() => Math.Max(RollAndTrackD20(), RollAndTrackD20());
    public static int RollAndTrackD20WithDisadvantage() => Math.Min(RollAndTrackD20(), RollAndTrackD20());
}
