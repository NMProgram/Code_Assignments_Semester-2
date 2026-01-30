static class Program
{
    static void Main()
    {
        Fighter you = new();
        Fighter enemy = new();
        int turnsTaken = 0;
        //Correct the code below
        for (; turnsTaken < 3; turnsTaken++)
        {
            enemy.Health -= you.Attack();
        }
        //Correct the code above

        /*
         * How many turns did it take you to defeat the enemy?
         * HINT: variable `i` is not in this scope;
         * can you change the code, so that it stays in scope?
         * There's also various other methods to fix this; any method is fine!
         */
        Console.WriteLine($"The enemy's HP was reduced to {enemy.Health}");
        Console.WriteLine($"It took you {turnsTaken} to defeat the enemy");
    }
}
