# Overview
This exercise introduces ways to handle `NullReferenceException`s caused by a `null` value in a given class.
It requires the programmer to fix an issue in the `Info()` method within the `Person` class provided.

Only the `Info()` method was changed by me, the rest was provided as a template by CodeGrade.

This was extremely simple to fix. The only thing that needed to change was to reverse the order of which the strings got returned by `Info()`.
I also changed the method into an expression-bodied method because why not?

# Code
For the Person and Animal classes, see the other .cs files in this directory.
```cs
static class Program
{
    static void Main()
    {
        Animal pet1 = null!;
        Person person1 = new("John Doe", pet1);
        Console.WriteLine(person1.Info());

        Animal pet2 = new("Max", "Whoof!");
        Person person2 = new("Jane Doe", pet2);
        Console.WriteLine(person2.Info());
    }
}
```
