# Overview
This exercise requires the programmer to implement the `Card` and `Deck` classes:
- The Card class is the same as seen in exercise `W02.1.1T10`, containing two string fields (this time `readonly`)
and the `string GetName()` method that returns the name of the card, depending on if it's a Joker.
- The Deck class contains a `List<Card>` field named `Cards` that gets filled with all existing cards with a unique Suit and Rank combination.
It then shuffles these with a `Random` instance's `Next()` method using the `void Shuffle()` method.
The `Draw()` method returns the last Card object instance in Cards and removes it from Cards.

Only the classes were implemented by me, the rest was provided as a template by CodeGrade.

This one took a little while to do, but that was mainly because I didn't read what to do with the `void Shuffle()` method correctly.
It was pretty self-explanatory once you understood how to form the `Cards` field and randomize it with `Random`.

# Code
For the classes, see the other .cs files in this directory.
```cs
using System.Reflection;

static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "ReadOnly": TestReadOnly(); return;
            case "Card": TestCard(); return;
            case "CreateDeck": TestCreateDeck(args[2] == "Jokers"); return;
            case "DeckMethods": TestDeckMethods(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        };
    }

    public static void TestReadOnly()
    {
        Type clsType = typeof(Card);
        PrintIsFieldReadOnly(clsType, "Suit");
        PrintIsFieldReadOnly(clsType, "Rank");

        clsType = typeof(Deck);
        PrintIsFieldReadOnly(clsType, "Cards");
    }

    public static void TestCard()
    {
        Card card = new("Spades", "Ace");
        Console.WriteLine(card.GetName());

        card = new("Hearts", "10");
        Console.WriteLine(card.GetName());

        card = new("Diamonds", "Queen");
        Console.WriteLine(card.GetName());
    }

    public static void TestCreateDeck(bool areJokersIncluded)
    {
        Deck deck = new(areJokersIncluded);
        foreach (var card in deck.Cards)
        {
            Console.WriteLine(card.GetName());
        }
    }

    public static void TestDeckMethods()
    {
        Console.WriteLine("=== Shuffling decks ===");
        // It is virtually impossible for two shuffled decks
        // to be the same, let alone three of them.

        Deck deck1 = new(true);
        string allCards1 = GetAllCardsAsString(deck1);
        
        Deck deck2 = new(true);
        string allCards2 = GetAllCardsAsString(deck2);

        Deck deck3 = new(true);
        string allCards3 = GetAllCardsAsString(deck3);

        Console.WriteLine($"Cards have been shuffled: {
            allCards1 != allCards2 && allCards1 != allCards3
        }");

        Console.WriteLine("\n=== Drawing cards ===");
        while (deck1.Cards.Count != 0)
        {
            deck1.Draw();
        }
        PrintCardsLeft(deck1);

        Console.WriteLine($"Deck is empty; any attempted card draw will be null: {deck1.Draw() is null}");
    }

    private static string GetAllCardsAsString(Deck deck)
    {
        string allCards = "";
        foreach (var card in deck.Cards)
        {
            allCards += card.GetName() + "\n";
        }
        return allCards;
    }

    private static void PrintCardsLeft(Deck deck)
    {
        Console.WriteLine($"{deck.Cards.Count} cards left");
    }

    private static void PrintIsFieldReadOnly(Type clsType, string fieldName)
    {
        FieldInfo info = clsType.GetField(fieldName,
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static)!;

        if (info is not null)
        {
            Console.WriteLine($"Field {info.Name} is read-only: " +
                info.IsInitOnly);
        }
        else
        {
            Console.WriteLine($"Field {fieldName} not found in {clsType.Name}");
        }
    }
}
```
