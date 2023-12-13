class Music
{
    public Music(Band artist, string name) 
    {
        Artist = artist;
        Name = name;  
    }

    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Disponible { get; set; }
    public string Description => $"A Música {Name} pertence a banda {Artist}";

    public void DisplayTechnicalSheet()
    {
        Console.WriteLine($"\nNome: {Name}");
        Console.WriteLine($"Artista: {Artist.Name}");
        Console.WriteLine($"Duração: {Duration}");
        if (Disponible)
        {
            Console.WriteLine("Essa Musica está disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus++");
        }
    }
}