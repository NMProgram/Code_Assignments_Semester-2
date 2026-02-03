# Overview
This exercise introduces the usage of `static` classes, classes that cannot be instantiated (no instance creation).
It requires the programmer to make a static `Calculator` class with the methods Add, Subtract, Multiply, Divide and Modulo, 
all having two `double` values return a `double` value using operators.

Only the `Calculator` class was coded by me, the rest was provided as a template by CodeGrade.

This one still doesn't really explain the `static` keyword, but it's a bit late to be doing that now anyway. 
Either way, this one's extremely easy, so nothing else needs to be said.

# Code
For the `Calculator` class, see Calculator.cs in this directory.
```cs
static class Program
{
    static void Main()
    {
        Console.WriteLine("Give the first number:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Give the second number:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{x} + {y} = {Calculator.Add(x, y)}");
        Console.WriteLine($"{x} - {y} = {Calculator.Subtract(x, y)}");
        Console.WriteLine($"{x} * {y} = {Calculator.Multiply(x, y)}");
        Console.WriteLine($"{x} / {y} = {Calculator.Divide(x, y)}");
        Console.WriteLine($"{x} % {y} = {Calculator.Modulo(x, y)}");
    }
}
```
