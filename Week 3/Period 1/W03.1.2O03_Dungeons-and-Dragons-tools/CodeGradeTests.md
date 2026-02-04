# Overview
This exercise requires the programmer to finish the given `GameTools` `static` class, 
by adding the fields `const int MinRoll = 1` `Dictionary<int, Dictionary<int, int>> DiceFrequency` and implementing the methods
`static int RollAndTrackDie()` and `static int RollAndTrackD20WithAdvantage()`/`static int RollAndTrackD20WithDisadvantage()`.
This class is meant to generate pseudorandom integers between two values: the constant MinRoll and a given amount of sides for the die. 
The outcome of that needs to be stored in the nested dictionary, with an incremented value for that specific roll.
The outcome also gets returned as an `int` value.

Only the `GameTools` class's new fields and methods were implemented by me, the rest was provided as a template by CodeGrade.

This one took a while, but was fairly simple once you understood how to set up the nested dictionary. 
It was honestly kinda fun, especially considering the last one was such a pain.

# Code
For the `GameTools` class and other CodeGrade test files, see the other files in this directory.
```cs
static class CodeGradeTests
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Readonly": TestReadonly.Start(); return;
            case "Constant": TestConstant.Start(); return;
            case "10Rolls": TestFunctionality.TestFrequencies(10); return;
            case "100Rolls": TestFunctionality.TestFrequencies(100); return;
            case "Advantage": TestFunctionality.TestD20WithAdvantage(); return;
            case "Disadvantage": TestFunctionality.TestD20WithDisadvantage(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }
}
```
