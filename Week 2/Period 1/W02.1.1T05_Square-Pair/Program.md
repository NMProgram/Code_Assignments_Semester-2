# Overview
This exercise introduces the instantiating of object instances.
It requires the programmer to print out the Side, Area and Perimeter of Square objects with values 5 and 10 as their initial values.

I mean, all you really do here is say `new(int)` to do this, so this wasn't very hard.
But I wanted to use a list here, and CodeGrade specifically wanted you to make them variables first, so that was kinda dumb.

# Code
See Square.cs for the Square class (that I did not make).
```cs
static class Program
{
    static void Main()
    {
        Square squareFive = new(5);
        Square squareTen = new(10);
        List<Square> squares = [squareFive, squareTen];
        foreach (Square square in squares)
        {
            Console.WriteLine($"Side: {square.Side}");
            Console.WriteLine($"Area: {square.GetArea()}");
            Console.WriteLine($"Perimeter: {square.GetPerimeter()}");
        }
    }
}
```
