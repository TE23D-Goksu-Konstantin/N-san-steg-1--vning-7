Random gen = new Random();
int gissningut;
string gissningin;
bool rätt = false;

while(rätt == false)
{
    Console.Clear();
Console.WriteLine("Du ska gissa på en slumpad siffra från 1-10, lycka till!");
int bil = Random.Shared.Next(1, 11);
gissningin = Console.ReadLine();
if(string.IsNullOrWhiteSpace(gissningin))
{
    Console.WriteLine("Det är ingen kuggfråga, så skriv något");
    Thread.Sleep(1500);
    continue;
}
int.TryParse(gissningin, out gissningut);
if(bil == gissningut)
{
    Console.Clear();
    Console.WriteLine($"Du gissade talet {bil}, vilket var rätt. Bra jobbat!");
    Thread.Sleep(500);
    Console.WriteLine("Hejdå");
    Thread.Sleep(3000);
    rätt = true;
}else{
    Console.WriteLine();
    Console.WriteLine("Fel, gör om och försök att göra rätt snela");
    Console.WriteLine($"Det rätta svaret var {bil}");
    Thread.Sleep(2000);
    }
}