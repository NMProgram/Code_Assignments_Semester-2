# Overview
This exercise introduces the existence of the class `ValueTuple<type1, type2, ...>`, which is similar to `Python`'s `tuple` datatype.
It requires the programmer to refactor the `GetSalaryRange()` method in the `EmployeeData` class 
to return a `ValueTupe<decimal, decimal>` instead of a `List<decimal>`.

Only the `GetSalaryRange()` method was altered by me, the rest was provided as a template by CodeGrade.

The only challenging part here was figuring out the syntax for the type name, the rest was easy.

# Code
For the `Employee` and `EmployeeData` classes, see the other .cs files in this directory.
```cs
static class CodeGradeTester
{
    static void Main()
    {
        EmployeeData employeeData = new(
        [
            new("Carl Lucas Cage", 55000),
            new("Clark Joseph Kent", 60000),
            new("Diana Prince", 60000),
            new("Peter Benjamin Parker", 50000),
        ]);

        (decimal, decimal) salaryRange = employeeData.GetSalaryRange();
        Console.WriteLine("Lowest salary: " + salaryRange.Item1);
        Console.WriteLine("Highest salary: " + salaryRange.Item2);
    }
}
```
