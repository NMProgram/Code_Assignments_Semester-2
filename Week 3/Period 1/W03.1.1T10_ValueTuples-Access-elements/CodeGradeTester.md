# Overview
This exercise introduces the usage of named ValueTuples using the `ValueTuple<>` type declaration. 
It requires the programmer to refactor a given `TestResultProcessor` class that still uses the old `Tuple` type as method parameters and return values.

Only the methods of `TestResultProcessor` were altered by me, the rest was provided as a template by CodeGrade.

I apparently skipped this one on accident, so I decided to do it now. The hardest part here was figuring out what the syntax was for a ValueTuple type parameter.

# Code
For the refactored class and another CodeGrade test file, see the other .cs files in this directory.
```cs
Martens, N. (1124834) at 2026-02-06 12:53
Latest
Actions

Edit

static class CodeGradeTester
{
    public static void Main(string[] args)
    {
        switch (args[1])
        {
            case "PrintResults": TestPrintResults(); return;
            case "GetAndPrintResults": TestGetAndPrintResults(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }

    public static void TestPrintResults()
    {
        TestUtils.PrintTupleParameterNames(typeof(TestResultProcessor), "PrintTestResult");

        (double Grade, bool HasPassed)[] results = [
            (5.5, true),
            (10.0, true),
            (5.6, true),
            (5.4, false),
            (2.5, false),
        ];

        foreach (var result in results)
        {
            TestResultProcessor.PrintTestResult(result);
        }
    }

    public static void TestGetAndPrintResults()
    {
        int[] pointsObtained = [0, 55, 100];
        int[] maxPoints = [100, 200];
        foreach (int max in maxPoints)
        {
            foreach (int points in pointsObtained)
            {
                (double Grade, bool HasPassed) result = TestResultProcessor.GetTestResult(points, max);
                TestResultProcessor.PrintTestResult(result);
            }
        }
    }
}
```
