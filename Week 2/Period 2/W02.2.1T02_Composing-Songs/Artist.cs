class Artist
{
    public string Name;
    public List<Song> ComposedSongs = [];

    public Artist(string name) => Name = name;

    // Your poetry here
    public void ComposeSong(string title) => ComposedSongs.Add(new Song(Name, title));
}
