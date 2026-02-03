# Overview
This exercise requires the programmer to create a `Point` class with two `double` fields `x` and `y`, 
alongside a `static` method `GetEuclideanDistance` that returns the distance between two Point object instances as a `double`.

Only the `Point` class was coded by me, the rest was provided as a template by CodeGrade.

The only hard thing about this was the fact that I thought I had to use the current instance's X and Y fields, 
when it was really just two Point objects given as arguments to the `GetEuclideanDistance` method.
So yeah, pretty easy to do, despite the complex sounding name of the exercise.

# Code
For the `Point` class, see Point.cs in this directory.
```cs
static class Program
{
    static void Main()
    {
        Point point1 = new(0, 0);
        Point point2 = new(1.5, 2.5);
        Point point3 = new(-3, -12.5);

        PrintEuclideanDistance(point1, point2);
        PrintEuclideanDistance(point1, point3);
        PrintEuclideanDistance(point2, point3);
    }

    private static void PrintEuclideanDistance(Point p1, Point p2)
    {
        Console.WriteLine($"Euclidean distance: {Math.Round(Point.GetEuclideanDistance(p1, p2), 2)}");
    }
}
```
