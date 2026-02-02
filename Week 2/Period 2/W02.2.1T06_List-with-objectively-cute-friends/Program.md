# Overview
This exercise officially introduces holding object class instances inside of a list (`List<object>`).
It requires the programmer to make a `List<Pet>` list variable in `Main()` using the class `Pet` 
and print out each one's `WhatAmI` and `Name` fields.

Only the `Main()` method of the `Program` class was coded by me, the rest was provided as a template by CodeGrade.

I guess this was another exercise trying to get people to use `foreach` loops, but I'm away ahead of them and used this in like week 1 period 2 or something.

# Code
For the Pet class, see Pet.cs in this directory.
```cs
static class Program
{
    static void Main()
    {
        /*Create a List of Pets here:
         *- a Dog named Nugent
         *- a Cat named Steve
         *- a Goldfish named Brutus
         */
        List<Pet> pets = [
            new("Dog", "Nugent"),
            new("Cat", "Steve"),
            new("Goldfish", "Brutus"),
        ];
        foreach (Pet pet in pets)
        {
            Console.WriteLine($"I have a {pet.WhatAmI} named {pet.Name}");
        }
    }
}
```
