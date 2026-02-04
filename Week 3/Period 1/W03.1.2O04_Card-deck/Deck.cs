class Deck
{
    public readonly List<Card> Cards = [];
    public bool AreJokersIncluded;
    public Deck(bool areJokersIncluded)
    {
        // Initialize AreJokersIncluded
        AreJokersIncluded = areJokersIncluded;

        // List Initialization
        List<string> suits = ["Diamonds", "Clubs", "Hearts", "Spades"];
        List<string> ranks = ["Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", 
                              "Jack", "Queen", "King"];
        foreach(string suit in suits)
        { foreach(string rank in ranks) { Cards.Add(new(suit, rank)); } }
        if (AreJokersIncluded) 
        { 
            Cards.Add(new("Red", "Joker")); 
            Cards.Add(new("Black", "Joker")); 
        }
        Shuffle();
    }
    public void Shuffle()
    {
        Random rand = new();
        List<Card> shuffledCards = [];
        for (; Cards.Count != 1;)
        {
            int rng = rand.Next(1, Cards.Count);
            shuffledCards.Add(Cards[rng]);
            Cards.Remove(Cards[rng]);
        }
        foreach (Card card in shuffledCards) { Cards.Add(card); }
    }
    public Card? Draw()
    {
        if (Cards.Count == 0) { return null; }
        Card lastEntry = Cards.Last();
        Cards.Remove(lastEntry);
        return lastEntry;
    }
}
