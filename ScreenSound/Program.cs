Music music1 = new Music();
music1.Name = "Lobo Guará";
music1.Artist = "Hungria";
music1.Duration = 271;
music1.Disponible = true;
Console.WriteLine(music1.Description);

Music music2 = new Music();
music2.Name = "Lembranças";
music2.Artist = "Hungria";
music2.Duration = 367;
music2.Disponible = false;

music1.DisplayTechnicalSheet();
music2.DisplayTechnicalSheet();