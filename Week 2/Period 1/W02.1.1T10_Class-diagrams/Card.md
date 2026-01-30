# Overview
This exercise introduces the concept of `Class Diagrams`, a part of the **UML** (Unified Modelling Language) that shows how a class is built.
It requires the programmer to build a `Card` class with a diagram, including a method `GetName(string, string)` to get the full name of a card.

It took me a while to figure out how to use fields in classes here. The rest was simple enough.

# Code
See `CodeGradeTester.cs` to see how this code is tested by CodeGrade.
```cs
class Card
{
    public static string? Suit;
    public static string? Rank;
    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }
    public string GetName() => (Suit != "Joker") ? $"{Rank} of {Suit}" : $"{Rank} {Suit}";
}
```
