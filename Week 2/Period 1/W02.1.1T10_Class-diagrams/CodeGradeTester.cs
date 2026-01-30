static class CodeGradeTester
{
    static void Main()
    {
        Card card = new("Spades", "Ace");
        Console.WriteLine(card.GetName());

        card = new("Hearts", "10");
        Console.WriteLine(card.GetName());

        card = new("Diamonds", "Queen");
        Console.WriteLine(card.GetName());
        
        card = new("Joker", "Red");
        Console.WriteLine(card.GetName());

        card = new("Joker", "Black");
        Console.WriteLine(card.GetName());
    }
}
