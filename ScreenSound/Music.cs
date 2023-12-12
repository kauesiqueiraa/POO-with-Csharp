class Music
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public bool Disponible { get; set; }
    public string Description => $"A Música {Name} pertence a banda {Artist}";

    public void DisplayTechnicalSheet()
    {
        Console.WriteLine($"\nNome: {Name}");
        Console.WriteLine($"Artista: {Artist}");
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