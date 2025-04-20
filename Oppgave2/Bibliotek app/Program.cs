using System;
using System.Collections.Generic;
using System.Linq;

// Abstrakt klasse Bok
abstract class Bok
{
    public string ISBN { get; set; }
    public string Tittel { get; set; }
    public string Forfatter { get; set; }
    public int Utgivelsesår { get; set; }

    public Bok(string isbn, string tittel, string forfatter, int utgivelsesår)
    {
        ISBN = isbn;
        Tittel = tittel;
        Forfatter = forfatter;
        Utgivelsesår = utgivelsesår;
    }

    public abstract void VisInfo(); // Må implementeres i subklassene
}

// Interface for bokfunksjoner
interface IBokFunksjoner
{
    void LånUt(); // Metode for å låne ut en bok
    void LeverInn(); // Metode for å levere inn en bok
}

// Subklasse Roman som arver fra Bok og implementerer IBokFunksjoner
class Roman : Bok, IBokFunksjoner
{
    public string Sjanger { get; set; }

    public Roman(string isbn, string tittel, string forfatter, int utgivelsesår, string sjanger)
        : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Sjanger = sjanger; 
    }

    public override void VisInfo()
    {
        Console.WriteLine($"[Roman] {Tittel} av {Forfatter} ({Utgivelsesår}) - Sjanger: {Sjanger}");
    }

    public void LånUt() => Console.WriteLine($"Boken '{Tittel}' er lånt ut.");
    public void LeverInn() => Console.WriteLine($"Boken '{Tittel}' er levert tilbake.");
}

// Subklasse Fagbok
class Fagbok : Bok, IBokFunksjoner
{
    public string Fagområde { get; set; }

    public Fagbok(string isbn, string tittel, string forfatter, int utgivelsesår, string fagområde)
        : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Fagområde = fagområde;
    }

    public override void VisInfo()
    {
        Console.WriteLine($"[Fagbok] {Tittel} av {Forfatter} ({Utgivelsesår}) - Fagområde: {Fagområde}");
    }

    public void LånUt() => Console.WriteLine($"Boken '{Tittel}' er lånt ut.");
    public void LeverInn() => Console.WriteLine($"Boken '{Tittel}' er levert tilbake.");
}

class Program 
{
    static List<Bok> bibliotek = new List<Bok>(); // Liste som holder alle nøkene i biblioteket

    static void Main()
    {
        bool kjører = true;
        while (kjører) // Hovedmeny med while-løkke
        {
            Console.WriteLine("\nBibliotek meny:");
            Console.WriteLine("1. Legg til bok");
            Console.WriteLine("2. Liste opp alle bøker");
            Console.WriteLine("3. Søk etter forfatter");
            Console.WriteLine("4. Søk etter utgivelsesår");
            Console.WriteLine("5. Finn bok etter tittel");
            Console.WriteLine("6. Avslutt");
            Console.Write("Velg et alternativ: ");

            string valg = Console.ReadLine();
            switch (valg)
            {
                case "1": LeggTilBok(); break; // Kaller metoden for å legge til en bok
                case "2": ListeOppBøker(); break; // Kaller metoden for å liste opp bøker
                case "3": SøkEtterForfatter(); break; // Kaller metoden for å søke etter forfatter
                case "4": SøkEtterUtgivelsesår(); break; // Kaller metoden for å søke etter utvigelsesår
                case "5": FinnBokEtterTittel(); break; //Kaller metoden for å finne en bok etter tittel
                case "6": kjører = false; break; // Avslutter programmet
                default: Console.WriteLine("Ugyldig valg, prøv igjen."); break;
            }
        }
    }

    static void LeggTilBok()
    {
        Console.Write("ISBN: "); string isbn = Console.ReadLine();
        Console.Write("Tittel: "); string tittel = Console.ReadLine();
        Console.Write("Forfatter: "); string forfatter = Console.ReadLine();
        Console.Write("Utgivelsesår: "); int utgivelsesår = int.Parse(Console.ReadLine());
        Console.Write("Type (1: Roman, 2: Fagbok): "); string type = Console.ReadLine();

        if (type == "1")
        {
            Console.Write("Sjanger: "); string sjanger = Console.ReadLine();
            bibliotek.Add(new Roman(isbn, tittel, forfatter, utgivelsesår, sjanger)); // Legger til roman i biblioteket
        }
        else if (type == "2")
        {
            Console.Write("Fagområde: "); string fagområde = Console.ReadLine();
            bibliotek.Add(new Fagbok(isbn, tittel, forfatter, utgivelsesår, fagområde)); // Legger til fagbok i biblioteket
        }
        else
        {
            Console.WriteLine("Ugyldig valg.");
        }
    }

    static void ListeOppBøker()
    {
        if (bibliotek.Count == 0)
        {
            Console.WriteLine("Ingen bøker i biblioteket.");
            return;
        }

        foreach (var bok in bibliotek) // Går gjennom alle bøker og viser info
        {
            bok.VisInfo();
        }
    }

    static void SøkEtterForfatter()
    {
        Console.Write("Skriv forfatterens navn: ");
        string forfatter = Console.ReadLine();
        var bøker = bibliotek.Where(b => b.Forfatter.Equals(forfatter, StringComparison.OrdinalIgnoreCase));

        foreach (var bok in bøker)
        {
            bok.VisInfo();
        }
    }

    static void SøkEtterUtgivelsesår()
    {
        Console.Write("Skriv inn år: ");
        int år = int.Parse(Console.ReadLine());
        var bøker = bibliotek.Where(b => b.Utgivelsesår > år);

        foreach (var bok in bøker)
        {
            bok.VisInfo();
        }
    }

    static void FinnBokEtterTittel()
    {
        Console.Write("Skriv inn boktittel: ");
        string tittel = Console.ReadLine();
        var bok = bibliotek.FirstOrDefault(b => b.Tittel.Equals(tittel, StringComparison.OrdinalIgnoreCase));
        
        if (bok != null)
            bok.VisInfo();
        else
            Console.WriteLine("Boken ble ikke funnet.");
    }
}
