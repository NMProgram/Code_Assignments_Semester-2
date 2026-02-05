[TestClass]
public class DiceBagTest
{
    /*
        Test the creation of an empty DiceBag object. 
        Check that the Dice field is not NULL and contains zero dice objects.
        
        Use the following Assert methods:
        - Assert.IsNotNull
        - Assert.AreEqual
    */
    [TestMethod]
    public void Constructor_Called_InitializesEmptyList()
    {
        // Arrange and Act
        DiceBag diceBag = new();
        List<Die> emptyList = [];

        // Assert
        Assert.IsNotNull(diceBag.Dice);
        Assert.AreEqual(0, diceBag.Dice.Count);
    }

    /*
        Test the Add method by adding multiple sided dice to a DiceBag.
        Check that the Dice field contains the correct number of dice and  
        that all dice contained in the Dice field are not NULL

        Use the following Assert methods:
        - Assert.AreEqual
        - CollectionAssert.AllItemsAreNotNull
    */
    [TestMethod]
    public void Add_NonNullDice_Added()
    {
        // Arrange

        // Create a new DiceBag
        DiceBag diceBag = new();
        List<int> sides = [4, 6, 8, 10, 20];
        // Act
        foreach (int side in sides)
        {
            diceBag.Add(new(side, "White"));
        }

        // Assert
        Assert.AreEqual(5, diceBag.Dice.Count);
        CollectionAssert.AllItemsAreNotNull(diceBag.Dice);
    }

    /*
        Test the Add method by adding a null Die to a DiceBag.
        Check that the Dice field contains 0 dice, 
        
        Use the following Assert method:
        - Assert.AreEqual
    */
    [TestMethod]
    public void Add_NullDie_NotAdded()
    {
        // Arrange
        // Create a new DiceBag
        DiceBag diceBag = new();

        // Act
        // Add a null die
        diceBag.Add(null);

        // Assert
        Assert.AreEqual(0, diceBag.Dice.Count);
    }

    /*
        Test the Reroll method of a DiceBag after adding dice. 
        After a Reroll, check if the value of all die in the DiceBag 
        are all within the correct range.
        
        Use the following Assert method:
        - Assert.IsTrue
    */
    [TestMethod]
    public void Reroll_ValidDice_DiceValuesInRange()
    {
        // Arrange

        // Create a new DiceBag with Dice
        DiceBag diceBag = new();
        List<int> sides = [4, 6, 8, 10, 20];
        foreach (int side in sides)
        {
            diceBag.Add(new(side, "White"));
        }
        // Act
        // Reroll all the dice
        diceBag.Reroll();

        // Assert
        foreach (Die die in diceBag.Dice)
        {
            Assert.IsTrue(die.Value >= 1 && die.Value <= die.Sides);
        }
    }
}
