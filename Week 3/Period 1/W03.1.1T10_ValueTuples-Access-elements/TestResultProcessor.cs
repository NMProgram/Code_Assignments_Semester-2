static class TestResultProcessor
{
    public static ValueTuple<double, bool> GetTestResult(int points, int maxPoints)
    {
        double grade = 10.0 * points / maxPoints;
        return (grade, grade >= 5.5);
    }

    public static void PrintTestResult((double Grade, bool HasPassed) result)
    {
        Console.WriteLine($"Grade: {result.Grade}");
        Console.WriteLine(result.HasPassed ? "Passed" : "Did not pass");
    }
}
