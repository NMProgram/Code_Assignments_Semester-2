class Circle
{
    public double Radius;
    public Circle(double radius) => Radius = radius;
    public double GetArea() => Math.PI * Math.Pow(Radius, 2);
}
