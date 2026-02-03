// Old Code
class Car
{
    public const int NumberOfWheels;
    public string Color;

    public Car(string color)
    {
        NumberOfWheels = 4;
        Color = color;
    }

    public void ChangePaintColor(string color) => Color = color;

    public string GetInfo()
    {
        return $"My color is currently {Color}, although that may change. "
            + $"But I will always have {NumberOfWheels} wheels.";
    }
}

// New Code
class Car
{
    public const int NumberOfWheels = 4;
    public string Color;

    public Car(string color)
    {
        Color = color;
    }

    public void ChangePaintColor(string color) => Color = color;

    public string GetInfo()
    {
        return $"My color is currently {Color}, although that may change. "
            + $"But I will always have {NumberOfWheels} wheels.";
    }
}
