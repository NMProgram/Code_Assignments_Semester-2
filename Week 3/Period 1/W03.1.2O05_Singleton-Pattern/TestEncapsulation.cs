using System.Reflection;

static class TestEncapsulation
{
    public static void TestConstructor()
    {
        Type clsType = typeof(FinancialCalculator);
        ConstructorInfo[] constructor = clsType.GetConstructors(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        if (constructor.Length == 0) // Should not be possible to have no constructors
        {
            Console.WriteLine("No constructor found; there must be exactly one constructor.");
            Console.WriteLine("(Is your class still static?)");
            return;
        }
        if (constructor.Length > 1)
        {
            Console.WriteLine("More than one constructor found; there may be only one");
            return;
        }

        Console.WriteLine($"Constructor is private: {constructor[0].IsPrivate}");
    }

    public static void TestField()
    {
        Type clsType = typeof(FinancialCalculator);
        FieldInfo? field = clsType.GetField("_instance",
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static);

        if (field == null)
        {
            Console.WriteLine("_instance field not found");
            return;
        }

        Console.WriteLine($"{clsType.Name} field is private: {field.IsPrivate}");
    }
}
