// Øvelse 1

// Øvelse 1 canvas modul 2.

using System; // Importer System for Console

class Program
{
    static void Main() // Main-metoden må være her
    {
int x, y, z, resultat;

Console.Clear();

Console.WriteLine("Vennligst skriv inn verdi for første tall: ");
x = int.Parse(Console.ReadLine());

Console.WriteLine("Vennligst skriv inn verdi for andre tall: ");
y = int.Parse(Console.ReadLine());

Console.WriteLine("Vennligst skriv inn verdi for tredje tall: ");
z = int.Parse(Console.ReadLine());

resultat = x * y * z;

Console.WriteLine($"Mulitiplikasjonsresultstet er: {resultat}");
    }
}       