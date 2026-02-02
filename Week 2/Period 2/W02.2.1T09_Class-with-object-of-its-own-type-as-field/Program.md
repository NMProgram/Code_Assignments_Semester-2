# Overview
This exercise introduces the concept of creating a field in a class of its own class type.
It requires the programmer to extend a given `DNA` class by adding a constructor with an `Ancestor` field that is equal to another instance of itself, 
and a normal string value `Seq`.
A method called `Replicate()` also had to be implemented that returns a new DNA object instance with a mutated sequence.

Only the `Replicate()` method and constructor of the `DNA` class were implemented by me, the rest was provided as a template by CodeGrade.

I don't really know what I did here, I just followed the instructions and it seemed to work. So yeah, that's something that happened.

# Code
For the DNA class, see the DNA.cs file in this directory.
```cs
static class Program
{
    static void Main()
    {
        DNA ancestor = new(null!, "acgt");
        List<DNA> dnaLine = [ancestor];
        for (int i = 0; i < 25; i++)
        {
            ancestor = ancestor.Replicate();
            dnaLine.Add(ancestor);
        }

        while (ancestor.Ancestor != null)
        {
            Console.WriteLine(ancestor.Ancestor.Seq);
            ancestor = ancestor.Ancestor;
        }
    }
}

```
