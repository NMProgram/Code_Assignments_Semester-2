# Overview
This exercise showcases how to assign to `readonly` fields, which is by assigning them once inside of the constructor of the class.
It requires the programmer to fix the `DatabaseManager` class by having the `readonly` field only be assigned to once inside of the constructor, 
while removing any traces of methods trying to change the value of the field.

Only parts of both the `Program` class and the `DatabaseManager` class were altered by me, the rest was provided as a template by CodeGrade.

I was a bit confused on what they wanted from me here at first, but then I realized you just remove anything that tries to assign a value to the field.
Very easy to do, and at least they explain themselves here.

# Code
For the `DatabaseManager` class, see DbManager.cs in this directory.
## Old Code
```cs
static class Program
{
    static void Main()
    {
        DatabaseManager dbm = new();
        dbm.Reassign("Reassign outside constructor");

        Console.WriteLine($"Current connection: {dbm.Connection}");
    }
}
```
## New Code
```cs
static class Program
{
    static void Main()
    {
        DatabaseManager dbm = new();

        Console.WriteLine($"Current connection: {dbm.Connection}");
    }
}
```
