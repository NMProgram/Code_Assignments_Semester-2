# Overview
This exercise requires the programmer to make two classes: `LimitedEditionCar` and `CarFactory`.
The LimitedEditionCar class has three fields with the field modifiers `static`, `const` and `readonly`, which have to correctly be placed next to the field names.
The CarFactory class only has a method `ProduceLimitedEditionCar()`, which returns a LimitedEditionCar instance with a specified ChassisNumber.

Only those two classes were coded by me, the rest was provided as a template by CodeGrade.

No matter what I tried, CodeGrade kept continually saying that the field modifiers I used for the three fields in `LimitedEditionCar` were wrong,
so I decided to say "Fuck this" and left it at what I have now. 
It tests those field modifiers using a hidden test method that you CANNOT view no matter what, 
meaning you practically have to guess what you did wrong with absolutely no hints whatsoever.

Just so we're on the same page here, let me reiterate why I think the field modifiers I used ARE correct:

- ChassisNumber: This field is meant to be assigned only once. That would mean it's `readonly`, right?
- Counter: This field is meant to be incremented each time a LimitedEditionCar instance is made.
This means that all instances would have the same Counter field value, so this should be `static`.
- Model: This field is the same over each instance and has to be assigned outside of the class constructor.
That would mean it should be `const`; a constant field that applies to all instances.

So as far as I know, this test is being incorrectly run, when looking at the description of the exercise.

# Code
For the other classes, see the other .cs files in this directory.
```cs
static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Modifiers": TestModifiers(); return;
            case "Car": TestCar(); return;
            case "Factory": TestFactory(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }

    public static void TestModifiers()
    {
        Console.WriteLine("The field modifiers are correct: " +
            TestFieldModifiers.AreModifiersCorrect()); // Hidden test
    }
    
    public static void TestCar()
    {
        Console.Write("How many cars will be created? ");
        int amount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < amount; i++)
        {
            LimitedEditionCar car = new();
            Console.WriteLine($"Car chassis number: {car.ChassisNumber}");
        }

        Console.WriteLine($"Counter after creating {amount} cars: {LimitedEditionCar.Counter}");
    }
    
    public static void TestFactory()
    {
        Console.Write("What is the limit for the amount of cars? ");
        int limit = Convert.ToInt32(Console.ReadLine());
        CarFactory factory = new(limit);

        Console.WriteLine("Starting production...");
        for (int i = 0; i < 10; i++)
        {
            LimitedEditionCar car = factory.ProduceLimitedEditionCar();
            if (car != null)
            {
                Console.WriteLine($" - Car #{i+1} produced");
            }
            else
            {
                Console.WriteLine("Not allowed to produce more");
                return;
            }
        }
    }
}
```
