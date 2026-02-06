# Overview
This exercise introduces the concept of using `finally` blocks in exception handling. 
It requires the programmer to add on to the last exercise by adding a `finally` block that closes the file after `try`-`catch` blocks have finished.

Only the `Program` class was altered by me, the rest was provided as a template by CodeGrade.

This was, again, a repeat of what I did in the last exercise, only now having to add a `finally` block into my code. 
I thought the `Dispose()` method would suffice, but I guess CodeGrade specifically wanted me to use the `Close()` method.

# Code
Other files are viewable in this directory.
```cs
using Newtonsoft.Json;

static class Program
{
    static void Main()
    {
        List<Person> people = DeserializeJson2People();

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

    public static List<Person> DeserializeJson2People()
    {
        string fileName = "People.json";
        StreamReader? reader = null;
        try
        {
            reader = new(fileName);
            string file2Json = reader.ReadToEnd();
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(file2Json)!;
            reader.Close();
            return people;
        }
        catch (FileNotFoundException notFound)
        {
            Console.WriteLine("Missing JSON File. " + notFound.Message);
            return new List<Person>();
        }
        catch (JsonReaderException jsonErr)
        {
            Console.WriteLine("Invalid JSON. " + jsonErr.Message);
            return new List<Person>();
        }
        finally
        {
            if (reader is not null) {reader.Close();}
        }
    }

    public static void SerializePeople2Json(List<Person> people)
    {
        string fileName = "People.json";
        StreamWriter writer = new(fileName);
        string list2Json = JsonConvert.SerializeObject(people);
        writer.Write(list2Json);
        writer.Close();
    }
}
```
