class Podcast
{
    private List<Episode> episodes = new List<Episode>();

    public Podcast(string name, string host) 
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }
    public int TotalEpisodes => episodes.Count;

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Podcast: {Name} apresentado por {Host} \n");
       foreach(Episode episode in episodes.OrderBy(e => e.Order))
        {
            Console.WriteLine(episode.Summary);
        }
        Console.WriteLine($"\nEste podcast possui {TotalEpisodes} Episódios");
    }
}