# Overview
This exercise introduces fields and constructors in classes with `C#`. 
It requires the programmer to finish a template version of the `Person` class, requiring a constructor.

I ended up not making a method for the constructor like CodeGrade probably wanted, 
because my VSCode Environment told me I could simplify it with putting the fields as parameters for the class. So there's that.

# Code
See `Person.cs` for my own code (with the provided template).
```cs
static class Program
{
    static void Main()
    {
        Person person1 = new("Bruce", "Wayne");
        Person person2 = new("Clark", "Kent");
        Person person3 = new("Diana", "Prince");

        List<Person> personList = [person1, person2, person3];
        foreach (var person in personList)
        {
            Console.WriteLine(person.GetIntroduction());
        }
    }
}
```
