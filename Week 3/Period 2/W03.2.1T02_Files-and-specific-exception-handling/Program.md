# Overview
This exercise introduces the usage of more specific exception handling by specifying the occured exception in the `catch (Exception)` block.
It's a carbon copy of exercise `W03.2.1T02`, but now requiring more specific exceptions to be caught and displayed on the console.

Only the `Program` class was altered by me, the rest was provided as a template by CodeGrade.

This one was obviously a copy of the last one, only having the exceptions be more specific, so this didn't take long at all.

# Code
Other files can be found in this directory.
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
        try
        {
            StreamReader reader = new(fileName);
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
