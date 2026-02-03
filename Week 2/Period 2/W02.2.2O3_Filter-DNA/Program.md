# Overview
This exercise requires the programmer to use a given `DNA` class to make a `List<DNA>` variable, ask the user for a minimum sequence length 
and print all sequences that are more than or equal to that length.

Only the `Main()` method of the `Program` class was coded by me, the rest was provided as a template by CodeGrade.

I'm not sure what the challenge was here, considering all you really need to do is use a `foreach` loop with an if-statement to print out the specific sequences.

# Code
For the `DNA` class, see the DNA.cs file in this directory.
```cs
static class Program
{
    static void Main()
    {
        List<DNA> DNAList = [new("ACGT"), new("GCTTAC"), new("CGTTAGCTT"), new("TACA")];
        Console.WriteLine("Enter the minimum sequence length: ");
        int minLength = int.Parse(Console.ReadLine()!);
        Console.WriteLine("The filtered list:");
        foreach (DNA dna in DNAList)
        {
            if (dna.Seq.Length >= minLength) { Console.WriteLine(dna.Seq); }
        }
    }
}
```
