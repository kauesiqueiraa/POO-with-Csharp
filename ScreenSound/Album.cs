class Album
{
    private List<Music> musics = new List<Music>();

    public Album(string name)
    {
        Name = name;
    }
    public string Name { get; }
    public int TimeTotal => musics.Sum(m => m.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void DisplayMusicFromAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}: \n");
        foreach (Music music in musics)
        {
            Console.WriteLine($"-> Música: {music.Name}");
        }
        Console.WriteLine($"\nPara ouvir esse album inteiro você precisa de {TimeTotal / 60} minutos");
    }
}