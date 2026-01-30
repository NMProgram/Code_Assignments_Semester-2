# Overview
This exercise requires the programmer to fix a given class `Cat` to make sure it prints out the `Name` field.

The only thing I changed was the name of the parameter, 
as it wouldn't be able to tell what value of the field is meant to be without it.

# Code
See `Cat.cs` for my solution.
```cs
class Program
{
    public static void Main()
    {
        Cat cat = new Cat("Fred");
        Console.WriteLine(cat.Name);
    }
}
```
