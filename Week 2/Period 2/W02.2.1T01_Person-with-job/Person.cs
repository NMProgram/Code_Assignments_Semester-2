class Person
{
    public string Name;
    public Job DayJob;

    public Person(string name, Job job)
    {
        Name = name;
        DayJob = job;
    }
    public string Info() => 
    (DayJob is not null) ? $"{Name} works as a {DayJob.Name}" : $"{Name} is in between jobs";
}
