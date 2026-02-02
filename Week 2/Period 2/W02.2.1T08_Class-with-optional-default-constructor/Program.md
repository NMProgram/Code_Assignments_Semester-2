# Overview
This exercise introduces the concept of using default values to fields in a constructor method within a class.
It requires the programmer to implement a `Button` class with default fields of `false` for `IsPressed` and `0` for `TimesPressed`.

Only the `Button` class was coded by me, the rest was provided as a template by CodeGrade.

This was also very simple, although I did overcomplicate the return value of the `Info()` method in `Button`, 
where I thought I had to return a tuple of values with different data types to then print them out later.
But it turns out you just need to use `\n` between two different strings formed by ternary operators.

# Code
For the Button class, see Button.cs in this directory.
```cs
static class Program
{
    static void Main()
    {
        Console.WriteLine("Press how many times?");
        int pressHowManyTimes = Convert.ToInt32(Console.ReadLine());
        
        Button button = new();
        for (int i = 0; i < pressHowManyTimes; i++)
        {
            button.Press();
        }
        
        Console.WriteLine(button.Info());
    }
}

```
