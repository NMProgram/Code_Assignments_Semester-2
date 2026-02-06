class Race
{
    public readonly string Location;
    public Race(string location) => Location = location;
    public static List<Driver> GetRaceResults(List<Driver> drivers)
    {
        Random rand = new();
        var copy = new List<Driver>(drivers);
        List<Driver> newList = [];
        do
        {
            int rng = rand.Next(0, copy.Count);
            newList.Add(copy[rng]);
            copy.Remove(copy[rng]);
        }
        while (copy.Count > 0);
        for (int i = 0; i < Season.PointsForPositions.Count; i++)
        { 
            newList[i].DriverPoints += Season.PointsForPositions[i]; 
        }
        return newList;
    }
}
