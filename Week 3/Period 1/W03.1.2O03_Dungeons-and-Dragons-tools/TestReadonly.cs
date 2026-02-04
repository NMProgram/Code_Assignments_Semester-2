using System.Reflection;

static class TestReadonly
{
    public static void Start()
    {
        PrintIsFieldReadOnly(typeof(GameTools), "Rand");
        PrintIsFieldReadOnly(typeof(GameTools), "DiceFrequencies");
    }

    private static void PrintIsFieldReadOnly(Type clsType, string fieldName)
    {
        FieldInfo? field = clsType.GetField(fieldName,
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static);

        if (field is null)
        {
            Console.WriteLine($"Field {fieldName} not found in {clsType.Name}");
            return;
        }

        Console.WriteLine($"{field.Name} is a read-only field: " +
            field.IsInitOnly);
    }
}
