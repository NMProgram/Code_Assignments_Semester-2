[TestClass]
public class DieTest
{
    /*
        Test the creation of a die: 
        - Check if Sides has been set correctly
        - Check if Color is not null
        - Check if Value is within a valid range
          - For example a six sided dice should have a rolled a value between 1 and 6 (inclusive). 

        You'll need to make three asserts. Use one of each of the following Assert methods:
        - Assert.AreEqual
        - Assert.IsNotNull
        - Assert.IsTrue
    */
    [TestMethod]
    public void Constructor_ValidParameters_InitializeCorrectly()
    {
        Die die = new(6, "White");
        Assert.AreEqual(6, die.Sides);
        Assert.IsNotNull(die.Color);
        Assert.IsTrue(die.Value >= 1 && die.Value <= 6);
    }

    /*
        Test the Roll method of multiple dice (4, 6, 8, 10 and 20-sided). 
        For each die, call the Roll method 10 times (in a for-loop) 
        and assert that the value is within a valid range
        (like in Constructor_ValidParameters_InitializeCorrectly) 

        Use the following Assert method:
        - Assert.IsTrue
    */
    [TestMethod]
    [DataRow(4)] // Fill the DataRows with the die sides
    [DataRow(6)]
    [DataRow(8)]
    [DataRow(10)]
    [DataRow(20)]
    public void Roll_ValidDie_ValueInRange(int sides)
    {
        Die die = new(sides, "White");
        for (int i = 0; i < 10; i++)
        {
            Assert.IsTrue(die.Value >= 1 && die.Value <= sides);
        }
    }

    /*
        Test that the ToString method returns a string in the expected format.

        Use the following Assert method:
        - Assert.AreEqual
    */

    [TestMethod]
    public void ToString_ValidDie_ExpectedFormat()
    {
        Die die = new(6, "White");
        Assert.AreEqual($"Sides: 6, color: White, value: {die.Value}", die.ToString());
    }
}
