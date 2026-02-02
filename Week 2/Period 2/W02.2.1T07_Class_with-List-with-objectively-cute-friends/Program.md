# Overview
This exercise introduces adding a list with object instances as a field in another class.
It requires the programmer to add the already created list of `Pet` instances from `W02.2.1T06` as a field to a `Person` instance,
and printing the name of the person, the WhatAmI field and the Name field of all Pet instances owned by Person.

Only the code in the `Main()` method of `Program` was coded by me, the rest was provided as a template by CodeGrade.

This is quite literally a carbon copy of the last exercise, except now it's a field in a different class. Not very hard.

# Code
For the Person and Pet classes, see the other .cs files in this directory.
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
        Person john = new("John", pets);
        foreach (Pet pet in john.Pets)
        {
            Console.WriteLine($"{john.Name} has a {pet.WhatAmI} named {pet.Name}");
        }
    }
}
```
