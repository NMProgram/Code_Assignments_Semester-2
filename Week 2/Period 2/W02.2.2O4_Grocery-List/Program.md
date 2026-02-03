# Overview
This exercise requires the programmer to implement three classes: `ShopItem`, `GroupedShopItem` and `ShoppingCart`. 
The first two only hold fields with Name, Quantity and Item, while the ShoppingCart class also holds methods 
for adding GroupedShopItem instances to a `List<GroupedShopItem>` field, 
finding a ShopItem in the field and returning product information from the Groceries field.

Only the three classes were coded by me, the rest was provided as a template by CodeGrade.

This one took a little longer than expected, 
mainly because I got stuck on where you were supposed to increment the quantity of the ShopItem in a GroupedShopItem instance.
That wasn't very well explained, but I eventually figured out that you just had to check if the ShopItem was already in the Groceries list.
So, not that bad, but definitely more challenging than the previous ones.

# Code
For the three classes, see the other .cs files in this directory.
```cs
static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "ShopItem": TestShopItem(); return;
            case "GroupedShopItem": TestGroupedShopItem(); return;
            case "Cart": TestShoppingCart(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }
    
    static void TestShopItem()
    {
        List<ShopItem> shopItems = [
            new("001A", "Bread", 3.50),
            new("001B", "Bread", 3.50),
            new("002A", "Skimmed milk", 1.85),
            new("002B", "Whole milk", 1.95),
            new("003A", "Sugar", 0.99),
        ];
        foreach (var item in shopItems)
        {
            Console.WriteLine($"{item.ID} {item.Name} {item.Price}");
        }
    }
    
    static void TestGroupedShopItem()
    {
        List<GroupedShopItem> gItems = [
            new GroupedShopItem(new ShopItem("0", "A", 0.5)),
            new GroupedShopItem(new ShopItem("1", "B", 1.5)),
            new GroupedShopItem(new ShopItem("2", "C", 2.5)),
        ];
        foreach (var gItem in gItems)
        {
            Console.WriteLine($"{gItem.Item.ID} {gItem.Item.Name} {gItem.Quantity}");
        }
    }
    
    static void TestShoppingCart()
    {
        ShopItem bread1 = new("001A", "Bread", 3.50);
        ShopItem bread2 = new("001B", "Bread", 3.50);
        ShopItem milk = new("002A", "Milk", 1.85);
        ShopItem sugar = new("003A", "Sugar", 0.99);

        ShoppingCart cart = new();

        cart.AddItem(milk);
        for (int i = 0; i < 3; i++)
        {
            cart.AddItem(bread1);
        }
        
        cart.AddItem(sugar);
        cart.AddItem(bread2);

        var gItem1 = cart.FindItem(new ShopItem("NONE", "Not existant", 0.0));
        var gItem2 = cart.FindItem(bread1);
        var gItem3 = cart.FindItem(bread2);
        foreach (var gItem in new GroupedShopItem[] { gItem1!, gItem2!, gItem3! })
        {
            Console.WriteLine(gItem == null ? "Not found" : $"{gItem.Item.ID} {gItem.Item.Name} {gItem.Item.Price}");
        }

        Console.WriteLine(cart.GetContentsOverview());
        Console.WriteLine(cart.GetTotalPrice());
    }
}
```
