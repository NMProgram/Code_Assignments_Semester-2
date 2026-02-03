# Overview
This exercise introduces the usage of `static` methods, methods that are only accessible within the class and not from an instance. 
It requires the programmer to make a `Scale` class that takes `UseKg` (bool) as a field and use the static method `ConvertKgToLbs()` in the method `GetWeight()`
to return a string with the converted (or not converted) weight.

Only the `Scale` class was coded by me, the rest was provided as a template by CodeGrade.

Same critique as the last one. They don't really explain what `static` does or means in this context. 
But whatever, I know what it is now, so why bother caring about it?

# Code
For the Scale class, see Scale.cs in this directory.
```cs
static class Program
{
    static void Main()
    {
        Scale scale = new Scale();
        Console.WriteLine(scale.GetWeight(60));

        scale.UseKg = false;
        Console.WriteLine(scale.GetWeight(60));
    }
}
```
