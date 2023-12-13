Band hungria = new Band("Hungria");

Album albumDoHungria = new Album("Hungria Hip-Hop");

Music music1 = new Music(hungria, "Lembranças")
{
    Duration = 213,
    Disponible = true,
};

Music music2 = new Music(hungria, "Não tenho freio.")
{
    Duration = 354,
    Disponible = false,
};

albumDoHungria.AddMusic(music1);
albumDoHungria.AddMusic(music2);

music1.DisplayTechnicalSheet();
music2.DisplayTechnicalSheet();

albumDoHungria.DisplayMusicFromAlbum();
hungria.AddAlbum(albumDoHungria);
hungria.DisplayDiscography();

Episode ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AddGuest("Maria");
ep1.AddGuest("Junior");

Episode ep2 = new(2, "Técnicas de aprendizado", 45);
ep2.AddGuest("Fernando");
ep2.AddGuest("Marcos");
ep2.AddGuest("Juliana");

Podcast podcast = new("Podcast Dev", "Kauè");
podcast.AddEpisode(ep1);
podcast.AddEpisode(ep2);
podcast.DisplayDetails();   

