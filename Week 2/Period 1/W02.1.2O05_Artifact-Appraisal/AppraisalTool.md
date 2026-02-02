# Overview
This exercise requires the programmer to add on to an existing `AppraisalTool` class 
that makes use of an `Artifact` class for storing artifacts in a `Dictionary<string, double>` field.
The programmer needs to extend the AppraisalTool class to allow artifacts to be added
and have all of the artifacts in the catalogue be printed by command with their values at their current condition.

Only the code below the comment is mine, the rest was provided as a template by CodeGrade.

This one was also very doable. It really only took a while to put together, the actual logic behind it was very simple.

# Code
For the Artifact class (not made by me), see the Artifact.cs file in this directory.
```cs
static class AppraisalTool
{
    public static Dictionary<string, double> Catalogue = new() {
        { "The Hope Diamond", 250_000_000 },
        { "The Mona Lisa", 50_000_000 },
        { "Tutankhamun's Mask", 5_000_000 },
        { "The Dead Sea Scrolls (Fragment)", 1_500_000 },
        { "A Roman Gladiator's Helmet", 1_000_000 },
        { "The Gutenberg Bible (Single Page)", 500_000 },
        { "A Viking Longship Fragment", 300_000 },
        { "An Ancient Greek Amphora", 200_000 },
        { "Rare stamp (1851 10c green)", 1_000 },
        { "A Samurai Katana from the Edo Period", 150_000 },
        { "A Pre-Columbian Gold Figurine", 100_000 },
    };

    static void Main()
    {
        Console.WriteLine("Appraising listed artifacts...");
        List<Artifact> listedArtifacts = [
            new("The Hope Diamond", 1),
            new("A Pre-Columbian Gold Figurine", 0),
            new("The Dead Sea Scrolls (Fragment)", 0.5),
            new("An Ancient Greek Amphora", 0.75),
        ];
        
        foreach (var artifact in listedArtifacts)
        {
            Appraise(artifact);
        }
        
        Console.WriteLine("\nAppraising unlisted artifacts...");
        List<Artifact> unlistedArtifacts = [
            new("Gom Jabbar", 1),
            new("Invisibility Cloak", 0.9),
            new("The Praetor Suit", 1),
            new("The Master Sword", 0),
        ];
        
        foreach (var artifact in unlistedArtifacts)
        {
            Appraise(artifact);
        }
        
        Console.WriteLine("\nAdding artifacts...");
        AddArtifact("Orb of Dragonkind", 2_000_000);
        AddArtifact("The Hope Diamond", 250_000_000);
        AddArtifact(" Leoric's Crown  ", 1_000_000);
        AddArtifact("  The Gutenberg Bible (Single Page) ", 500_000);
        
        Console.WriteLine("\nPrinting Catalogue...");
        PrintCatalogue();
    }
    
    // Your valuable code goes here
    public static string ValueString(double value) => value switch
    {
        >= 1_000 and < 1_000_000 => $"{value / 1_000}k",
        >= 1_000_000 => $"{value / 1_000_000}M",
        _ => $"{value}"
    };
    /*
    Value of artifact 'The Hope Diamond': 250M
    If the artifact is not in the catalogue, print instead:
    Artifact 'The Hope Diamond' not in catalogue
    */
    public static void Appraise(Artifact artifact)
    {
        bool inCatalogue = Catalogue.TryGetValue(artifact.Name, out double value);
        value *= artifact.ConditionRate;
        string msg = inCatalogue ? $"Value of artifact \'{artifact.Name}\': {ValueString(value)}" : 
        $"Artifact \'{artifact.Name}\' not in catalogue";
        Console.WriteLine(msg);
    }
    public static void AddArtifact(string name, int value)
    {
        name = name.Trim();
        if (!Catalogue.ContainsKey(name))
        {
            Catalogue.Add(name, value);
            Console.WriteLine($"Added artifact \'{name}\'");
            return;
        }
        Console.WriteLine($"Artifact \'{name}\' already in catalogue");
    }
    public static void PrintCatalogue()
    {
        Console.WriteLine("Catalogue:");
        foreach (KeyValuePair<string, double> pair in Catalogue)
        {
            string msg = $" - Artifact: \'{pair.Key}\', Perfect Condition Value: {ValueString(pair.Value)}";
            Console.WriteLine(msg);
        }
    }
}
```
