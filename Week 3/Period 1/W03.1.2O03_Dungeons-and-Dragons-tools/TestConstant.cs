using System.Reflection;

static class TestConstant
{
    public static void Start()
    {
        PrintIsFieldConstant(typeof(GameTools), "MinRoll");
        Console.WriteLine($"MinRoll value: {GameTools.MinRoll}");
    }

    private static void PrintIsFieldConstant(Type clsType, string fieldName)
    {
        FieldInfo? field = clsType.GetField(fieldName,
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static);

        if (field is null)
        {
            Console.WriteLine($"Field {fieldName} not found in {clsType.Name}");
            return;
        }

        Console.WriteLine($"{field.Name} is a constant field: " + field.IsLiteral);
    }
}
