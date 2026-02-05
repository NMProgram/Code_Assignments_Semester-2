class Patient
{
    public static int totalPatients = 0;
    public readonly string Id;
    public string Name;
    public int Age;
    public Patient(string name, int age)
    {
        totalPatients++;
        Id = totalPatients switch
        {
            < 10 => "PAT" + "00" + totalPatients,
            >= 10 and < 100 => "PAT" + "0" + totalPatients,
            >= 100 => "PAT" + totalPatients,
        };
        Name = name;
        Age = age;
    }
}
