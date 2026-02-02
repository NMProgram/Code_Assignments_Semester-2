# Overview
This exercise introduces the creation of object instances within another class's method.
It requires the programmer to implement a `ComposeSong(string title)` method inside the `Artist` class, using the `Song` class provided by CodeGrade,
where a Song instance gets added to a `List<Song>` field in the Artist class.

Only the last method in the Artist class was coded by me, the rest was provided as a template by CodeGrade.

This, again, isn't very difficult. I literally added one line of code to make it work.

# Code
For the Artist and Song classes, see the other .cs files in this directory.
```cs
static class Program
{
    static void Main()
    {
        Artist artist1 = new("Rihanna");
        artist1.ComposeSong("Umbrella");
        artist1.ComposeSong("Where Have You Been");
        
        Artist artist2 = new("Michael Jackson");
        artist2.ComposeSong("Billy Jean");
        artist2.ComposeSong("Thriller");

        foreach (Artist artist in new[] { artist1, artist2 })
        {
            foreach (Song song in artist.ComposedSongs)
            {
                Console.WriteLine(song.Info());
            }
        }
    }
}
```
