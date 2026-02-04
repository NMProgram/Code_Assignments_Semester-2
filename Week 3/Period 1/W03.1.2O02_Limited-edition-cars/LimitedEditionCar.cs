class LimitedEditionCar
{
    public const string Model = "Mclaren F1";
    public readonly string ChassisNumber;
    public static int Counter = 0;
    public LimitedEditionCar()
    {
        Counter++;
        ChassisNumber = "CHNO" + Counter;
    }
}
