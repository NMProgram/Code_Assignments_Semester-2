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
