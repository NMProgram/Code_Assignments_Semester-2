public class Player
{
    public string Name;
    public int Power, HealthPoints;
    public Player(string name, int power)
    {
        Name = name;
        Power = power;
        HealthPoints = 100;
    }

    public bool IsAlive() => HealthPoints > 0;

    public void TakeDamage(int dmg) => HealthPoints -= (HealthPoints - dmg > 0) ? dmg : HealthPoints;
}
