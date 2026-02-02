# Overview
This exercise requires the programmer to make a Player class with HP, Attack Power and a name as fields 
and to create two instances of that class that battle eachother until one of them reaches 0 HP using a while-loop.
This exercise also emphasizes the importance of making the classes part of their own file with the same name as the class.

I only filled in certain details within the Program class, the rest was provided as a template by CodeGrade. 
The Player class was coded entirely by me, however.

It took a bit to figure out how to actually make fields with the Player class (since I still haven't gotten used to the `public` and `static` keywords),
but it was straight-forward once I had done that. As usual, CodeGrade's template was missing a `\n` and graded my code as incorrect for that reason,
but that was a very simple thing to fix. There's also a null reference warning in the template provided, but I'm not the one who made that code so whatever.
Overall, a good exercise for learning how to create fields in `C#`, with some issues with the template.

# Code
For the Player class, see Player.cs in this directory.
```cs
static class Program
{
    static void Main()
    {
        Player p1 = new("John Snow", 30);
        Player p2 = new("Night King", 60);
        PrintPlayerStats(p1);
        PrintPlayerStats(p2);
        
        Player winner = null;
        while (p1.IsAlive() && p2.IsAlive())
        {
            p1.TakeDamage(p2.Power);
            if (!p1.IsAlive())
            {
                winner = p2;
                break;
            }

            p2.TakeDamage(p1.Power);
            if (!p2.IsAlive())
            {
                winner = p1;
                break;
            }

            PrintPlayerStats(p1);
            PrintPlayerStats(p2);
        }

        PrintPlayerStats(p1);
        PrintPlayerStats(p2);
        Console.WriteLine($"\n-----The winner is:-----\n{winner.Name}: {winner.Power} Power; {winner.HealthPoints} Healthpoints");
    }
    
    static void PrintPlayerStats(Player? player)
    {
        if (player == null) { return; }
        Console.WriteLine($"{player.Name}: {player.Power} Power; {player.HealthPoints} Healthpoints");
    }
}
```
