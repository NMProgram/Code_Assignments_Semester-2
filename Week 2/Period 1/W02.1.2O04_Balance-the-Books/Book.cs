public class Book
{
    public int ID;
    public string Title;
    public Book(int id, string title)
    {
        ID = id;
        Title = title;
    }

    public string GetInfo() => $"ID: {ID}, Title: {Title}";
}
