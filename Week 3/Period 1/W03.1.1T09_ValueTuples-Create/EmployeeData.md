# Overview
This exercise introduces the existence of the class `ValueTuple<type1, type2, ...>`, which is similar to `Python`'s `tuple` datatype.
It requires the programmer to refactor the `GetSalaryRange()` method in the `EmployeeData` class 
to return a `ValueTupe<decimal, decimal>` instead of a `List<decimal>`.

Only the `GetSalaryRange()` method was altered by me, the rest was provided as a template by CodeGrade.

The only challenging part here was figuring out the syntax for the type name, the rest was easy.

# Code
For the `Employee` class and the `CodeGradeTester` class, see the other .cs files in this directory.
## Old Code
```cs
class EmployeeData
{
    private readonly List<Employee> Employees;
    public EmployeeData(List<Employee> employees) => Employees = employees;

    public List<decimal> GetSalaryRange()
    {
        decimal minSalary = decimal.MaxValue;
        decimal maxSalary = decimal.MinValue;

        foreach (var employee in Employees)
        {
            if (employee.Salary < minSalary)
                minSalary = employee.Salary;

            if (employee.Salary > maxSalary)
                maxSalary = employee.Salary;
        }

        return [minSalary, maxSalary];
    }
}
```
## New Code
```cs
class EmployeeData
{
    private readonly List<Employee> Employees;
    public EmployeeData(List<Employee> employees) => Employees = employees;

    public ValueTuple<decimal, decimal> GetSalaryRange()
    {
        decimal minSalary = decimal.MaxValue;
        decimal maxSalary = decimal.MinValue;

        foreach (var employee in Employees)
        {
            if (employee.Salary < minSalary)
                minSalary = employee.Salary;

            if (employee.Salary > maxSalary)
                maxSalary = employee.Salary;
        }

        return (minSalary, maxSalary);
    }
}
```
