class Season
{
    public readonly int Year;
    public readonly List<Race> Races;
    public readonly List<Team> Teams;
    public static readonly List<int> PointsForPositions = [25, 18, 15, 12, 10, 8, 6, 4, 2, 1];
    public Season(int year, List<Race> races, List<Team> teams)
    {
        Year = year;
        Races = races;
        Teams = teams;
    }
    public void RunSeason()
    {
        List<Driver> drivers = [];
        foreach (var team in Teams)
            {
                foreach (var driver in team.Drivers)
                { drivers.Add(driver); }
            }
        for (int i = 0; i < Races.Count; i++)
        { 
            Race.GetRaceResults(drivers); 
            Driver? winner = null;
            foreach (var driver in drivers)
            {
                if (winner is null) 
                { winner = driver; }
                else if (winner.DriverPoints < driver.DriverPoints) 
                { winner = driver; }
            }
            Console.WriteLine($"{winner!.Name} of {winner.TeamName} has won the {Races[i].Location} Grand Prix!");
        }
    }
    public void PrintSeasonResults()
    {
        List<Driver> drivers = [];
        Console.WriteLine("Season results:");
        foreach (var team in Teams)
        {
            foreach (var driver in team.Drivers)
            {
                drivers.Add(driver);
            }
        }
        drivers = drivers.OrderBy(Driver => Driver.DriverPoints).ToList();
        for (int i = 1; i <= drivers.Count; i++)
        {
            Console.WriteLine($"{i}. {drivers[^i].Name}: {drivers[^i].DriverPoints}");
        }
    }
}
