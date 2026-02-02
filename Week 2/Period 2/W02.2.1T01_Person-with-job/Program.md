# Overview
This exercise introduces the usage of fields in classes that are instances of other classes.
It requires the programmer to make a `Person` class with the given template of a `Job` class to display the name and job of that specific Person.

Only the Person class was coded by me, the rest was provided as a template by CodeGrade.

No real challenge here. The only confusing thing was that I had to deal with a null value, which I had at first not tested for accordingly in my ternary operator.

# Code
For the Job and Person classes, see the other .cs files in this directory.
```cs
static class Program
{
    static void Main()
    {
        List<Job> jobs = [
            new("Waiter", 25000.0),
            new("Math teacher", 50000.0),
            new("Clown", 10000.0),
            new("Developer", 90000.0),
            new("Bus Driver", 40000.0),
        ];

        Person person = new("Jane", jobs[0]);
        Console.WriteLine(person.Info());

        for (int i = 1; i < jobs.Count; i++)
        {
            person.DayJob = person.DayJob!.GetJobWithHigherSalary(jobs[i])!;
        }
        Console.WriteLine(person.Info()); // Should now have the job with the highest salary

        person.DayJob = null!;
        Console.WriteLine(person.Info());
    }
}
```
