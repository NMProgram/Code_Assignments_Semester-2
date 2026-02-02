# Overview
This exercise requires the programmer to create three methods that check if a given year is considered a leap year.
A year is only considered a leap year if it is divisible by 4 and (divisible by 400 or not divisible by 100).

This was fairly simple to do, considering it's pretty much a repeat of the original "Leap year" exercise from BaseCamp.
I struggled with that exercise in the earlier weeks, just because I didn't understand the modulus operator `%` yet.

# Code
To see the Unit Test used by CodeGrade, see LeapYearTest.cs in this directory.
```cs
public static class Program
{
    public static bool IsDivisibleBy(int num, int division) => num % division == 0;

    public static bool IsLeapYear(int year) => 
    IsDivisibleBy(year, 4) && (!IsDivisibleBy(year, 100) || IsDivisibleBy(year, 400));

    public static void PrintIsLeapYear(int year)
    {
        bool status = IsLeapYear(year);
        string msg = status ? $"{year} is a leap year" : $"{year} is not a leap year";
        Console.WriteLine(msg);
    }

    public static void Main()
    {
        List<int> values = [1000, 1500, 2000, 2004, 2005];
        foreach (int value in values)
        {
            PrintIsLeapYear(value);
        }
    }
}
```
