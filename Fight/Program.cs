Brawler brawler = new Brawler();
Gladiator gladiator = new Gladiator();

Console.WriteLine($"{brawler.name} has {brawler.health} healths");
Console.WriteLine($"{gladiator.name} has {gladiator.health} health");

Console.WriteLine("Hit");
brawler.health -= 50;

Console.WriteLine($"{brawler.name} now has {brawler.health} health");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();

Console.WriteLine("Hit");
brawler.health -=50 ;
Console.WriteLine($"{brawler.name} now has {brawler.health}");
Console.WriteLine("Gahban dog din fakking askar mannen");
Console.ReadKey();
