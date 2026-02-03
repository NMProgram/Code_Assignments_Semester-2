# Overview
This exercise introduces how to use static class like `Math`.
It requires the programmer to make a `Circle` class with a `double` Radius field 
and a `double GetArea()` method for returning the area of the circle (using `Math.PI` and `Math.Pow()`).

Only the `Circle` class was coded by me, the rest was provided as a template by CodeGrade.

I guess this sorta explains what static classes are, but for some reason they still haven't explained static methods and static fields. Strange.
The exercise was extremely easy, though.

# Code
For the `Circle` class, see Class.cs in this directory.
```cs
static class Program
{
    static void Main()
    {
        Console.WriteLine("Give the circle radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new(radius);

        Console.WriteLine($"Rounded circle area: {Math.Round(circle.GetArea())}");
    }
}
```
