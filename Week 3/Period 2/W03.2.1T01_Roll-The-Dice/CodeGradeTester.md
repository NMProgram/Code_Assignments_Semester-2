# Overview
This exercise introduces the usage of unit tests in `C#`, requiring the programmer to make their own unit tests for the two given classes `Die` and `DiceBag`.
The Die class has the fields `Sides`, `Color` and `Value`, while DiceBag holds a `List<Die>` field that can be rerolled with the `Reroll()` method.

Only the Unit Test files were coded by me, the rest was provided as a template by CodeGrade.

This took me forever to figure out, mainly because I couldn't get MSTest to work on my VSCode environment for the life of me. 
Eventually, I figured out I had to first create an MSTest project with `dotnet new mstest -n {project_name}`, 
followed by `dotnet new console -o {project_name}` through the terminal in the same directory as the MSTest folder.
After that, there were some very specific asserts CodeGrade wanted me to use, 
which made it a little hard to figure out the exact thing that made their own tests fail.
So yeah, another painful process of CodeGrade not cooperating and me struggling to understand how to make a unit testing project. Hooray.

# Code
For the Unit Tests and other classes, see the other .cs files in this directory.
```cs
static class CodeGradeTester
{
    static void Main()
    {
        Console.WriteLine("Welcome to Roll The Dice!");

        List<int> lSides = [ 4, 6, 8, 10, 20 ];
        List<string> lColors = [ "green", "blue", "yellow", "red" ];

        DiceBag diceBag = new();
        Random rand = new(); // Create random number generator

        lSides.ForEach(side =>
        {
            string MyColor = lColors[rand.Next(0, lColors.Count)];
            Die MyDie = new(sides: side, color: MyColor); // Create new object based on class Die
            diceBag.Add(MyDie); // Add object Die to the object DiceBag
        });
        diceBag.PrintInfo();
        
        diceBag.Reroll(); // Reroll all the dice in the bag
        diceBag.PrintInfo();
    }
}
```
