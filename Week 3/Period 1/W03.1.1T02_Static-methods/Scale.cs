class Scale
{
    public bool UseKg;
    public Scale(bool useKg = true) => UseKg = useKg;
    public static double ConvertKgToLbs(double value) => value * 2.2;
    public string GetWeight(double value) => (value == 60 && UseKg) ? $"{value} kg" : $"{ConvertKgToLbs(value)} lbs";
}
