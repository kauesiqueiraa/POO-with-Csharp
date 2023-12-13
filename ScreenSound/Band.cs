class Band
{
    private List<Album> albuns = new List<Album>();

    public Band(string name)
    {
        Name = name;
    }
    public string Name { get; }

    public void AddAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void DisplayDiscography()
    {
        Console.WriteLine($"\nDiscografia da Banda {Name}");
        foreach(Album album in albuns)
        {
            Console.WriteLine($"--> Álbum: {album.Name} ({album.TimeTotal}) <--");
        }
    }
}