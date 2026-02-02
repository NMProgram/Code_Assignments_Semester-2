# Overview
This exercise requires the programmer to implement a while-loop within a given template of different classes relating to the position of a player on a map.
The user needs to be asked which direction they'd like to go in, until they reach the goal. 
Only specific directions are allowed per location that the player can enter.

Only the while-loop was coded by me. The rest was provided as a template by CodeGrade.

This one was very confusing, and I still don't really feel accomplished for completing it. 
It throws four different classes at you with no context and expects you to understand everything at play with just a few lines of documentation.
Not a big fan of this one, for sure.

# Code
For the other files, see the .cs files in this directory.
```cs
static class Program
{
    static void Main()
    {
        /* Below is a map of 6 Locations.
         * The Player starts at 1 and the goal is to move to 6.
         * +---+
         * |123|
         * | 4 |
         * | 56|
         * +---+
         */

        Player player = new(World.Locations[0]); // Create player
        player.CurrentLocation = World.Locations[0]; // Place player at Location 1

        Console.WriteLine("Current location: " + player.CurrentLocation.Name);
        Console.WriteLine(player.CurrentLocation.Compass());
        Console.WriteLine("Location to the east: " + player.CurrentLocation.GetLocationAt("E").Name);
        player.TryMoveTo(player.CurrentLocation.GetLocationAt("E")); // Moves the Player to Location 2
        
        /*
         * Write a while-loop that continues until the Player has arrived at the Goal.
         * At each iteration, ask the user for a direction (N/E/S/W), then try to move the Player.
         * For example:
         * - player.TryMoveTo("N") will move the Player north IF there is a Location;
         * - player.TryMoveTo("Hello") will not move the Player;
         * - player.TryMoveTo(null) will not move the Player.
         */

        // VVV YOUR CODE GOES HERE VVV
        while (player.CurrentLocation != World.Locations.Last())
        {
            Console.WriteLine("Choose a direction (N/E/S/W):");
            Location direction = player.CurrentLocation.GetLocationAt(Console.ReadLine()!);
            if (!player.TryMoveTo(direction))
            {
                Console.WriteLine("Invalid direction.");
            }
            Console.WriteLine("Current location: " + player.CurrentLocation.Name);
            Console.WriteLine(player.CurrentLocation.Compass());
        };


        // ^^^YOUR CODE GOES HERE ^^^

        Console.WriteLine("You have arrived at the goal!");
    }
}
```
