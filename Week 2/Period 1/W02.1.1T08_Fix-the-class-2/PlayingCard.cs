// Old Code
class PlayingCard
{
    public string Suit;
    public string Rank;

    public void PlayingCard(string suit, string rank)
    {
        this.Suit = suit;
        this.Rank = rank;
    }

    public string GetDescription() => $"The {this.Rank} of {this.Suit}";
}

// New Code
class PlayingCard
{
    public string Suit;
    public string Rank;

    public PlayingCard(string suit, string rank)
    {
        this.Suit = suit;
        this.Rank = rank;
    }

    public string GetDescription() => $"The {this.Rank} of {this.Suit}";
}
