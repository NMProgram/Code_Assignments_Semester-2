# Overview
This exercise requires the programmer to make a `Task` class with a name and status, 
and a `ToDo` class that holds Task objects inside of a `List<Task>` field.

Only the `Task` and `ToDo` classes were coded by me, the rest was provided as a template by CodeGrade.

The only challenging part here was the fact that CodeGrade's Program.cs template file used a `string[] args` parameter inside of the `Main()` method of `Program`, 
which I had to find out how to run correctly in VSCode.
Next to that, CodeGrade also wanted a very specific way of returning the string in the `Info()` method of `Task`, which was a little annoying. 
But still easy to do, overall.

# Code
For the Task and ToDo classes, see the other .cs files in this directory.
```cs
static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Task": TestTask(); return;
            case "TODO": TestToDo(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }
    
    static void TestTask()
    {
        Task simple = new("Test");
        Console.WriteLine(simple.Info());
    }
    
    static void TestToDo()
    {
        ToDo today = new();
        today.AddTask("T1");
        today.AddTask("T2");
        today.AddTask("T3");
        today.AddTask("T4");

        Task? task1 = today.GetTask("T2");
        Task? task2 = today.GetTask("T4");
        Task? task3 = today.GetTask("T5");

        task1?.Done(); // if (task1 != null) task1.Done(); 
        task2?.Done();
        task3?.Done();

        Console.WriteLine(today.Report());
    }
}
```
