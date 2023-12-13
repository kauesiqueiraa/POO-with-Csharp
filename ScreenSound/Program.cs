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
