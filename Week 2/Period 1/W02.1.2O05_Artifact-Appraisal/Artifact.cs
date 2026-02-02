class Artifact
{
    public string Name;
    public double ConditionRate; // Must be between 0 (broken) and 1 (perfect)

    public Artifact(string name, double conditionRate)
    {
        if (conditionRate < 0 || conditionRate > 1)
            throw new ArgumentOutOfRangeException(nameof(conditionRate), "ConditionRate must be between 0 and 1.");
    
        Name = name;
        ConditionRate = conditionRate;
    }
}
