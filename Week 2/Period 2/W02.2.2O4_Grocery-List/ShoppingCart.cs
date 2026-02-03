class ShoppingCart
{
    public List<GroupedShopItem> Groceries;
    public ShoppingCart() => Groceries = [];
    public void AddItem(ShopItem item)
    {
        foreach (GroupedShopItem grocery in Groceries)
        {
            if (grocery.Item == item) { grocery.Quantity++; return; }
        }
        Groceries.Add(new(item));
    }
    public GroupedShopItem? FindItem(ShopItem item)
    {
        foreach (GroupedShopItem grocery in Groceries)
        { if (grocery.Item == item) { return grocery; } }
        return null;
    }
    public string GetContentsOverview()
    {
        string multilineString = "";
        foreach (GroupedShopItem grocery in Groceries)
        {
            string add = $"{grocery.Item.Name} x {grocery.Quantity}";
            multilineString += add + "\n";
        }
        return multilineString;
    }
    public double GetTotalPrice()
    {
        double price = 0.0;
        foreach (GroupedShopItem grocery in Groceries)
        { price += grocery.Item.Price * grocery.Quantity; }
        return price;
    }
}
