using WebaruhazApp;

Termek monitor = new Termek("Monitor", 80000);
AkciosTermek billentyuzet = new AkciosTermek("Billentyűzet", 20000, 20);

monitor.NettoAr = -5000;
billentyuzet.KedvezmenySzazalek = 150;

Console.WriteLine(monitor.ToString());
Console.WriteLine(billentyuzet.ToString());
Console.WriteLine($"Katalógusban levő összes termék száma: {Termek.OsszesTermekSzama} db");