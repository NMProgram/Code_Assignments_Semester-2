public class DiceBag
{
    public List<Die> Dice = []; // Contains all Die objects

    public void Add(Die die)
    {
        if (die is not null) // If the die is not null...
            Dice.Add(die); // ... add it to the bag.
    }

    // Reroll the vallues of all dice in the bag and print info for each die.
    public void Reroll() => Dice.ForEach(dice => dice.Roll());

    // Custom method like ToString, but prints directly to the console.
    public void PrintInfo()
    {
        this.Dice.ForEach(die => Console.WriteLine(die));
    }
}
