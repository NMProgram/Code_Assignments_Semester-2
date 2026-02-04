# Overview
This exercise requires the programmer to refactor the code for a given `FinancialCalculator` class to take up less memory 
by forcing it to only have one instance up at a time 
and having it take up minimal amount of memory when not in use.

Only the `FinancialCalculator` class was altered by me, the rest was provided as a template by CodeGrade.

This one was fairly simple, although a little vague with the description. I ended up doing this without a problem, but I'm not sure *what* I did, 
since encapsulation hasn't been introduced yet. So, all in all, a very strange exercise.

# Code
For other class files, see the other files in this directory.
```cs
static class CodeGradeTests
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "NonStaticClass": TestNonStatic.TestClassIsNotStatic(); return;
            case "NonStaticMembers": TestNonStatic.TestOnlyInstanceAndGetInstanceAreStatic(); return;
            case "PrivateConstructor": TestEncapsulation.TestConstructor(); return;
            case "PrivateField": TestEncapsulation.TestField(); return;
            case "Readonly": TestReadonly.Start(); return;
            case "Cache": TestFunctionality.TestCache(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }
}
```
