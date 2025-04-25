using System;
using System.Collections.Generic;
using System.Linq;

class Program // Hovedprogram
{
    static List<Bok> bibliotek = new List<Bok>();  // Lager en liste for å lagre bøker

    static void Main()
    {
        bool kjører = true;
        while (kjører) // Hovedmeny som kjører i en løkke til bruker avslutter
        {
            Console.Clear();
            Console.WriteLine("\nBibliotek meny:");
            Console.WriteLine("1. Legg til bok");
            Console.WriteLine("2. Liste opp alle bøker");
            Console.WriteLine("3. Søk etter forfatter");
            Console.WriteLine("4. Søk etter utgivelsesår");
            Console.WriteLine("5. Finn bok etter tittel");
            Console.WriteLine("6. Avslutt");
            Console.Write("Velg et alternativ: ");

            string valg = Console.ReadLine();
            switch (valg)   // Utfører valg basert på menyen
            {
                case "1": LeggTilBok(); break;
                case "2": ListeOppBøker(); break;
                case "3": SøkEtterForfatter(); break;
                case "4": SøkEtterUtgivelsesår(); break;
                case "5": FinnBokEtterTittel(); break;
                case "6": kjører = false; break; // Stopper programmet
                default: Console.WriteLine("Ugyldig valg, prøv igjen."); break;
            }
        }
    }

    static void LeggTilBok()  // Lar bruker legge til en bok i listen
    {
        Console.Write("ISBN: "); string isbn = Console.ReadLine();
        Console.Write("Tittel: "); string tittel = Console.ReadLine();
        Console.Write("Forfatter: "); string forfatter = Console.ReadLine();
        Console.Write("Utgivelsesår: "); int utgivelsesår = int.Parse(Console.ReadLine());
        Console.Write("Type (1: Roman, 2: Fagbok): "); string type = Console.ReadLine();

        if (type == "1")  // Lager enten Roman eller Fagbok basert på brukerens valg
        {
            Console.Write("Sjanger: "); string sjanger = Console.ReadLine();
            bibliotek.Add(new Roman(isbn, tittel, forfatter, utgivelsesår, sjanger));
        }
        else if (type == "2")
        {
            Console.Write("Fagområde: "); string fagområde = Console.ReadLine();
            bibliotek.Add(new Fagbok(isbn, tittel, forfatter, utgivelsesår, fagområde));
        }
        else
        {
            Console.WriteLine("Ugyldig valg.");
        }
    }

    static void ListeOppBøker()    // Skriver ut alle bøker i listen
    {
        if (bibliotek.Count == 0)
        {
            Console.WriteLine("Ingen bøker i biblioteket.");
            return;
        }

        foreach (var bok in bibliotek)
        {
            bok.VisInfo(); // Kaller metoden som viser info om bok
        }
    }

    static void SøkEtterForfatter()  // Søker etter bøker skrevet av en bestemt forfatter
    {
        Console.Write("Skriv forfatterens navn: ");
        string forfatter = Console.ReadLine();
        var bøker = bibliotek.Where(b => b.Forfatter.Equals(forfatter, StringComparison.OrdinalIgnoreCase));

        foreach (var bok in bøker)
        {
            bok.VisInfo();
        }
    }

    static void SøkEtterUtgivelsesår()  // Søker etter bøker utgitt etter et gitt år
    {
        Console.Write("Skriv inn år: ");
        int år = int.Parse(Console.ReadLine());
        var bøker = bibliotek.Where(b => b.Utgivelsesår > år);

        foreach (var bok in bøker)
        {
            bok.VisInfo();
        }
    }

    static void FinnBokEtterTittel() // Søker etter bok med bestemt tittel
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
