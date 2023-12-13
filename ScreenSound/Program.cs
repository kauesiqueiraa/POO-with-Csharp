Album albumDoHungria = new Album();
albumDoHungria.Name = "Hungria Hip-Hop";

Music music1 = new Music();
music1.Name = "Lembranças";
music1.Duration = 213;

Music music2 = new Music();
music2.Name = "Não tenho freio.";
music2.Duration = 354;

albumDoHungria.AddMusic(music1);
albumDoHungria.AddMusic(music2);

albumDoHungria.DisplayMusicFromAlbum();
