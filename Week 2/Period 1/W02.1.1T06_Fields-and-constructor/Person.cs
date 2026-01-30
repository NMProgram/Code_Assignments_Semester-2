// Old Code
class Person
{


    public string GetIntroduction() => $"I am {FirstName} {LastName}";
}


// New Code
class Person(string FirstName, string LastName)
{
    public string GetIntroduction() => $"I am {FirstName} {LastName}";
}
