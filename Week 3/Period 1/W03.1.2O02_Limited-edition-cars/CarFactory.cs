/* 
I tried to remove the public field MaxCars 
and make it assigned through the primary constructor here, 
but to no avail.
*/

class CarFactory(int MaxCars)
{
    // public CarFactory(int maxCars)
    // {
    //     public const int MaxCars =;
    //     LimitedEditionCar.Counter = 0;
    // }
    public LimitedEditionCar? ProduceLimitedEditionCar()
    {
        LimitedEditionCar newCar = new();
        if (LimitedEditionCar.Counter <= MaxCars) { return newCar;  }
        return null;
    }
}
