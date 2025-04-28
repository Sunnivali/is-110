using System;       // importerer nødvendige biblioteker i C#
using System.Collections.Generic;
using System.Linq;

class Program
{
    const string strBokNotFound = "Boken ble ikke funnet.";  // definerer en konstat som brukes senere når boken ikke blir funnet
    static List<Bok> bibliotek = new List<Bok>();  // en liste for å lagre alle bøkene i biblioteket

    static void Main()
    {
        bool kjører = true;
        while (kjører)  // hovedløkke som viser en meny til brukeren til programmet avsluttes
        {
            // meny for bruker instruksjoner
            Console.WriteLine("\nBibliotek meny:");
            Console.WriteLine("1. Legg til bok");
            Console.WriteLine("2. Liste opp alle bøker");
            Console.WriteLine("3. Søk etter forfatter");
            Console.WriteLine("4. Søk etter utgivelsesår");
            Console.WriteLine("5. Finn bok etter tittel");
            Console.WriteLine("6. Er bok inne?");
            Console.WriteLine("7. Lån bok");
            Console.WriteLine("8. Lever inn bok");
            Console.WriteLine("9. Avslutt");
            Console.WriteLine("");
            
            Console.Write("Velg et alternativ: "); // brukeren velger et alternativ fra menyen

            string valg = Console.ReadLine(); // leser brukerens valg fra konsollen 
            switch (valg) // bruker en switch setning for å utføre handlinger basert på brukerens valg 
                            //kontrollstruktur som brukes til å velge mellom flere mulige alternativer basert på en uttrykk
            {
                case "1": LeggTilBok(); break; // kaller funksjonen for å legge til en bok
                case "2": ListeOppBøker(); break; // break, hopper ut av switch-blokken etter å ha utført case 2
                case "3": SøkEtterForfatter(); break;
                case "4": SøkEtterUtgivelsesår(); break;
                case "5": FinnBokEtterTittel(); break;
                case "6": SjekkOmBokErInne(); break;
                case "7": LaanUtBok(); break;
                case "8": LeverInnBok(); break;
                case "9": kjører = false; break; // programmet stopper når bruker velger 9
                default: Console.WriteLine("Ugyldig valg, prøv igjen."); break; // informerer bruker om at valget er ugyldig
            }
        }
    }

    static void LeggTilBok() // legger til en ny bok i bibliotek
    {
        Console.Write("ISBN: "); string isbn = Console.ReadLine();
        Console.Write("Tittel: "); string tittel = Console.ReadLine();
        Console.Write("Forfatter: "); string forfatter = Console.ReadLine();
        Console.Write("Utgivelsesår: "); int utgivelsesår = int.Parse(Console.ReadLine());
        Console.Write("Type (1: Roman, 2: Fagbok): "); string type = Console.ReadLine();

        if (type == "1") // legger til bok avhengig av hvilken type boken er
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

    static void ListeOppBøker() // skriver ut en liste over alle bøker i biblioteket
    {
        if (bibliotek.Count == 0) // sjekker om biblioteket er tomt
        {
            Console.WriteLine("Ingen bøker i biblioteket.");
            return;     // avslutter metoden hvis biblioteket er tomt
        }

        foreach (var bok in bibliotek) // løkke som går gjennom hver bok i biblioteket
        {
            bok.VisInfo();  // kaller metoden VisInfo på boken, som viser detaljer om boken
        }
    }

    static void SøkEtterForfatter() // søker ettet bøker skrevet av en spesifikk forfatter
    {
        Console.Write("Skriv forfatterens navn: ");
        string forfatter = Console.ReadLine();   // leser inn forfatterens navn basert på bruekrens input
        
        var bøker = bibliotek       // filtrerer bøker basert på forfatter
            .Where(b => b.Forfatter.IndexOf(forfatter, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();      // lager en liste med bøker der forfatterens navn finner i forfatter felt (case insensitive)

        if (bøker.Any())   // dersom det finnes noen bøker i listen
        {
            foreach (var bok in bøker)  // (løkke) går gjennom alle bøkene som ble funnet
            {
                bok.VisInfo();  // kaller VisInfo for å vise detaljer om boken
            }
        }
        else        // dersom ingen bøker ble funnet
        {
            Console.WriteLine($"Fant ingen bøker skrevet av {forfatter}.");
        }
    }

    static void SøkEtterUtgivelsesår()
    {
        Console.Write("Skriv inn år: ");    // ber brukeren skrive inn et årstall
        int år = int.Parse(Console.ReadLine());     // leser inn brukerens input og gjør den om til heltall (int)
        
        var bøker = bibliotek.Where(b => b.Utgivelsesår > år);      // filtrerer bøker der utgivelsesåret er større enn det brukeren skrev inn

        if (bøker.Any())        // dersom det finnes minst en bok som matcher, utføres følgende:
        {
            foreach (var bok in bøker)      // går gjennom hver bok som ble funnet
            {
                bok.VisInfo();      // viser informasjonen om boken som ble funnet
            }
        }
        else        // dersom ingen bøker ble funnet utføres følgende:
        {
            Console.WriteLine($"Ingen bøker funnet etter år {år}.");        // skirver ut melding
        }
    }

    static void FinnBokEtterTittel()
    {
        Console.Write("Skriv inn boktittel: ");     // ber bruker skrive inn tittel på boken de vil finne
        string tittel = Console.ReadLine();     // leser inn brukerens inputsom en tekststreng
        var bok = bibliotek.FirstOrDefault(b => b.Tittel.Equals(tittel, StringComparison.OrdinalIgnoreCase));
            // søker etter den første boken i biblioteket der tittelen matcher brukerens input


        if (bok != null)        // dersom det ble funnet enn bok, skjer følgende:
            bok.VisInfo();      // viser informasjon om boken
        else        // dersom ingen bok ble funnet:
            Console.WriteLine(strBokNotFound); // skirver ut melding om at boken ikke ble funnet
    }

    static void SjekkOmBokErInne()
    {
        Console.WriteLine("Skriv inn boktittel: ");     // ber brukeren skrive inn tittelen på boken de vil sjekke
        string tittel = Console.ReadLine();     // leser inn boktittelen fra brukeren
        var bok = bibliotek.FirstOrDefault(b => b.Tittel.Equals(tittel, StringComparison.OrdinalIgnoreCase));
        // søker etter den første boken i biblioteket som har samme tittel som brukeren skrev inn


        if ( bok != null)       // sjekker om boken er inne
        {
            if (bok.BokInne)            // BokInne er property i klassen Bok => kan nåst direkte, hvis boken er inne skjer følgende:
            {
                Console.WriteLine($"Boken '{tittel}' er inne!");        // gir beskjed om at boken er tilgjengelig
            }
            else        // dersom boken ikke er inne:
            {
                Console.WriteLine($"Boken '{tittel}' er på utlån!");        // gir beskjed om at boken er lånt ut
            }
        }
        else        // dersom ingen bok med gitt tittel ble funnet:
        {
            Console.WriteLine(strBokNotFound);      //viser feilmelding: boken finnes ikke
        }
    }

    static void LaanUtBok()
    {
        Console.WriteLine("Bok som skal lånes: ");      // ber bruker skrive inn tittelen på boken de vil finne
        string tittel = Console.ReadLine();     // leser inn boktittelen fra brukeren
        var bok = bibliotek.FirstOrDefault(b => b.Tittel.Equals(tittel, StringComparison.OrdinalIgnoreCase));
        // søker etter den første boken i biblioteket som har samme tittel

        if ( bok is IBokFunksjoner fbok)    // Cast for å nå methods i IBokFunksjoner 
            // sjekker om boken finnes, og om den kan behandles som en bok med utlånsfunksjoner (IBokFunksjoner)
        {
            fbok.LaanUt();      // låner ut boken, ved å kalle metoden LaanUt
        }
        else        // dersom boken ikke finnes
        {
            Console.WriteLine(strBokNotFound);      //viser feilmelding: boken finnes ikke
        }        
    }

    static void LeverInnBok()
    {
        Console.WriteLine("Bok som skal leveres tilbake: ");        // ber bruker skrive inn tittelen på boken de vil levere inn
        string tittel = Console.ReadLine();     // leser inn boktittelen fra brukeren
        var bok = bibliotek.FirstOrDefault(b => b.Tittel.Equals(tittel, StringComparison.OrdinalIgnoreCase));
            // søker etter den første boken i biblioteket som har samme tittel

        if ( bok is IBokFunksjoner fbok)    // "is"-operatoren + casting slik at vi kan bruke LeverInn()-metoden
                // sjekker om boken finnes, og om den kan behandles som en bok med innleveringsfunksjoner (IBokFunksjoner)
        {
            fbok.LeverInn();        // leverer inn boken ved å kalle metoden LeverInn
        }
        else        // dersom boken ikke finnes
        {
            Console.WriteLine(strBokNotFound);      // skriver ut feilmeldingen: Boken boken ble ikke funnet
        }
    }
}



// ISBN: 9788203450112
// Tittel: Da vi var yngre
// Forfatter: Oliver Lovrenski
// Utvigelsesår: 2023
// Sjanger: Skjønnlitteratur