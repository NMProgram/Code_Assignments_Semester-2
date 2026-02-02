class Person
{
    public string Name;
    public Animal? Pet;

    public Person(string name, Animal pet)
    {
        Name = name;
        Pet = pet;
    }

    public string Info() => (Pet is null) ? 
    $"{Name} has no pet" : $"{Name} has a pet that makes the sound {Pet.MakeSound()}";
}
