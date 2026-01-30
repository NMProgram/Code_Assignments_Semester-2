# Overview
This exercise requires the programmer to fix a given class `PlayingCard` with a compile error.

The only thing I did here was change the constructor method to not have `void` before the method name. That was it.

# Code
See `PlayingCard.cs` for my solution.
```cs
static class Program
{
    static void Main()
    {
        PlayingCard card = new("Spades", "Ace");
        Console.WriteLine(card.GetDescription());
    }
}
```
