# Overview
This exercise requires the programmer to fix a method in the `Ventilator` class to not throw a `ArgumentOutOfRangeException` 
and to fix the return value of a switch expression in the `Blow()` method.
The Ventilator class also makes use of a `Button` class with only a boolean field called `IsPressed`, 
which there are four different Button instances thrown into one list within the `Ventilator` class.

Only the `IsPressed()` method in the `Ventilator` class was altered by me, the rest was provided as a template by CodeGrade.

It took a couple tries to fix the `IsPressed()` method because I didn't realize negative numbers were also being tested in the Program.cs file.
Other than that, this was very simple to do.

# Code
For the Ventilator and Button classes, see the other .cs files in this directory.
```cs
static class Program
{
    static void Main()
    {
        Ventilator ventilator = new();
        for (int i = -1; i <= 4; i++)
        {
            ventilator.PressButton(i);
            Console.WriteLine(ventilator.Blow());
        }
    }
}
```
