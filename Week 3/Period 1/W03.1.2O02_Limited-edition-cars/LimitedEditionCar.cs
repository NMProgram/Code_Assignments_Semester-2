class LimitedEditionCar
{
    public readonly string ChassisNumber;
    public static int Counter = 0;
    public const string MODEL = "Mclaren F1";
    public LimitedEditionCar()
    {
        Counter++;
        ChassisNumber = "CHNO" + Counter;
    }
}
