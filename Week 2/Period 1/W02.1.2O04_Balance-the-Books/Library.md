# Overview
This exercise requires the programmer to make a `Book` class with an ID and title, 
and a `Library` class that holds multiple Book instances within a `List<books>` attribute.
These classes also had to be given specific methods for looking up certain books within the library with the ID and managing which books are in the `Books` list.

Everything outside of the CodeGradeTester file was coded by me.

This one was pretty simple to do, although the CodeGradeTester file did confuse me for a while, as I was trying to make it work in my VSCode IDE.
However, I was unable to do so, which makes me think there's something internal within CodeGrade that allows the file to run.

# Code
For the Book class and CodeGradeTester file, see the other files in this directory.
```cs
public class Library(int MaxBooks)
{
    public List<Book> Books = [];
    public bool AddBook(int id, string title)
    {
        if (Books.Count < MaxBooks)
        {
            Book book = new(id, title);
            Books.Add(book);
            return true;
        }
        return false;
    }
    public Book FindBookById(int id)
    {
        foreach (Book book in Books)
        {
            if (book.ID == id) { return book; }
        }
        return null;
    }
    public void EditBookTitle(int id, string newTitle)
    {
        Book book = FindBookById(id);
        if (!book.Equals(null))
        {
            book.Title = newTitle;
        }
    }
    public void RemoveBookById(int id)
    {
        List<Book> booksCopy = new List<Book> (Books);
        foreach (Book book in booksCopy)
        {
            if (book.ID.Equals(id))
            {
                Books.Remove(book);
            }
        }
    }
}
```
