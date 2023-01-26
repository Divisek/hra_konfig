// See https://aka.ms/new-console-template for more information
string konfig = "fullscreeen shaDows autosave";
konfig = konfig.ToLower();
Console.WriteLine("Poběží hra ve fullscreenu?");
Console.WriteLine(konfig.Contains("fullscreen"));
Console.WriteLine("Budou zapnuté stíny?");
Console.WriteLine(konfig.Contains("shadows"));
Console.WriteLine("Přeje si hráč vypnout zvuk?");
Console.WriteLine(konfig.Contains("nosound"));
Console.WriteLine("Přeje si hráč hru automaticky ukládat?");
Console.WriteLine(konfig.Contains("autosave"));
Console.ReadKey();

