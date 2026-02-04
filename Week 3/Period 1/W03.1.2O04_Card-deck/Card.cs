class Card
{
    public readonly string Suit, Rank;
    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }
    public string GetName() => (Rank == "Joker") ? $"{Suit} {Rank}" : $"{Rank} of {Suit}";
}
