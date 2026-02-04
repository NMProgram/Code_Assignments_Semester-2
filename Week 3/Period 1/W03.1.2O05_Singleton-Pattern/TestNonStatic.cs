using System.Reflection;

static class TestNonStatic
{
    public static void TestClassIsNotStatic()
    {
        Type clsType = typeof(FinancialCalculator);
        Console.WriteLine($"{clsType.Name} is NOT static: {!(clsType.IsAbstract && clsType.IsSealed)}");
    }

    public static void TestOnlyInstanceAndGetInstanceAreStatic()
    {
        Type clsType = typeof(FinancialCalculator);
        var staticMembers = clsType.GetMembers(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var member in staticMembers)
        {
            if (member.Name != "_instance" && member.Name != "GetInstance")
            {
                Console.WriteLine("Found a static member");
                return;
            }
        }

        Console.WriteLine("Only `_instance` and `GetInstance` are static");
    }
}
