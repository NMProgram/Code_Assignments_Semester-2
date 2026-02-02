# Overview
This exercise introduces the existence of hard and soft copies of class instances with a reference type.
It requires the programmer to implement a `DNA` class with one method that returns a new DNA object with the same sequence value,
one that returns its own instance and one that converts the sequence value to another string value.

Only the DNA class was coded by me, the rest was provided as a template by CodeGrade.

This one was very easy, but it also brought attention to the `this` keyword, which I did not fully understand yet. 
I mean, even after doing this, it's still a little vague, but I understand what it does now at the very least.

# Code
For the DNA class, see the other .cs file in this directory.
```cs
static class Program
{
    static void Main()
    {
        DNA dnaA = new("ACGT");
        DNA dnaB = dnaA.Replicate1();
        dnaA.Mutate("TCGT");
        CompareDNA(dnaA, dnaB);

        Console.WriteLine();

        DNA dnaC = new("CGTA");
        DNA dnaD = dnaC.Replicate2();
        dnaC.Mutate("CCGA");
        CompareDNA(dnaC, dnaD);
    }

    static void CompareDNA(DNA dna1, DNA dna2)
    {
        Console.WriteLine($"{dna1.Seq} and {dna2.Seq} are {(dna1.Seq == dna2.Seq ? "" : "not ")}the same sequence");
        Console.WriteLine($"dna1 and dna2 are {(dna1 == dna2 ? "" : "not ")}the same");
    }
}

```
