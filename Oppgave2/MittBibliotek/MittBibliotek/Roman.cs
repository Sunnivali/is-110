class Roman : Bok, IBokFunksjoner   // arver fra bok, implementerer IBokFunksjoner-interface
{
    public string Sjanger { get; set; }   // leser og henter verdi


    // Constructor
    public Roman(string isbn, string tittel, string forfatter, int utgivelsesår, string sjanger)
        : base(isbn, tittel, forfatter, utgivelsesår) // kaller konstruktøren i superklassen, Bok som Roman arver fra
    {
        Sjanger = sjanger;       // setter egenskapen "Sjanger" til verdien som ble sendt inn som parameter "sjanger"
    }

    // Overriding Abstract Methods
    public override void VisInfo()
    {
        Console.WriteLine($"[Roman] {Tittel} av {Forfatter} ({Utgivelsesår}) - Sjanger: {Sjanger}. ISBN {ISBN}");
    }           //overrider den abstrakte VisInfor metoden fra Bok-klassen, for å vise spesifikk informasjon om en roman

    // INTERFACE METHODS
    public void LaanUt() // metode LaanUt
    {
        // sjekker om boken er tilgjengelig for utlån
        if (BokInne)  // utføren en kodeblokk hvis betingelsen er sann
        {
            BokInne = false; // hvis boken er inne (BokInne = true), lånes den ut og status oppdateres til utlånt (BokInne = fale)
            Console.WriteLine($"Romanen '{Tittel}' er nå lånt ut.");
        }
        else
        {           // hvis boken allerede er utlånt, vises en melding om at boken er på utlån
            Console.WriteLine($"Romanen '{Tittel}' er på utlån!");
        }
    }
    public void LeverInn() // metode for å levere inn bok
    {
        if (!BokInne) // sjekker om boken er inne
        {
            BokInne = true;     //setter bokens status til "inne", som betyr at den er levert tilbake
            Console.WriteLine($"Romanen '{Tittel}' er nå levert tilbake.");  // skriver ut melding om at boken er levert tilbake
        }
        else  // hvis boken allerede er inne i biblioteket
        {       
            Console.WriteLine($"Romanen '{Tittel}' er allerede levert tilbake."); // skriver ut melding
        }
    }

    public bool ErBokInne() // metode for å sjekke om boken er inne i bibliotek eller ikke
    {
        return BokInne; // returnerer verdien til BokInne, og kan være ture (inne) eller false (utlånt)
    }
}