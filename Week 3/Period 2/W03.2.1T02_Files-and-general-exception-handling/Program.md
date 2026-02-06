# Overview
This exercise introduces the concept of exception handling in `C#`. It requires the programmer to take a given `Program` class 
and refactor the methods to include excpetion handling for reading and writing to files.

Only the Program class was altered by me, the rest was provided as a template by CodeGrade.

This one took forever, because for some reason CodeGrade didn't accept the `[]` syntax as an empty list. 
I was also unable to run the file in CodeGrade for whatever reason. Very weird.

# Code
For the other class files, see the other .cs files in this directory.
```cs
using Newtonsoft.Json;

static class Program
{
    static void Main()
    {
        List<Person> people = DeserializeJson2People()!;

        foreach (Person person in people)
        {
            foreach (Car car in person.OwnedCars)
            {
                for (int i = 0; i < 5; i++)
                {
                    car.Drive();
                }
            }
        }

        SerializePeople2Json(people);
    }

    public static List<Person>? DeserializeJson2People()
    {
        string fileName = "People.json";
        try
        {
            StreamReader reader = new(fileName);
            string file2Json = reader.ReadToEnd();
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(file2Json)!;
            reader.Close();
            return people;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
            return null;
        }
    }

    public static void SerializePeople2Json(List<Person> people)
    {
        string fileName = "People.json";
        try
        {
            StreamWriter writer = new(fileName);
            string list2Json = JsonConvert.SerializeObject(people);
            writer.Write(list2Json);
            writer.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
```
