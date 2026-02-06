# Overview
This exercise requires the programmer to fix the amount of money given to employees of a company. 
The travel reimbursement is not being added to their salary due to there being no distant employees,
which results in a `DivideByZeroException` and a return value of `0`.

Only the `Company` class was altered by me, the rest was provided as a template by CodeGrade.

The hardest part about this one was figuring out what to start with, considering CodeGrade gave me almost no help orienting myself.
Once I figured out that a DivideByZeroException was occuring, 
I was able to realize that the return value for the `CalculateTravelAllowance()` method was equal to 0 after an exception were to occur.
That obviously wasn't meant to happen, so I changed it to return the standard amount, plus the max travel allowance budget divided by the amount of employees.
Not too bad, considering it requires you to change one line of code, but still took a little bit of time to figure out.

# Code
Other files are viewable in this directory, including the `Company` class I altered.
```cs
class Program
{
    public static void Main()
    {
        var company = new Company();
        var people = new List<Employee>()
        {
            new Employee(3000, 10),
            new Employee(2500, 20),
            new Employee(3500, 15),
            new Employee(3000, 20),
        };
        foreach (var person in people)
        {
            company.Hire(person);
        }

        company.PayMonthlySalary();
        foreach (var employee in company.Employees)
        {
            Console.WriteLine($"Employee has earned {employee.SalaryEarned}");
        }
    }
}
```
