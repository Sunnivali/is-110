class Fagbok : Bok, IBokFunksjoner // arver fra bok, implementerer IBokFunksjoner-interface
{
    public string Fagområde { get; set; }   // leser og henter verdi

    // Constructor
    public Fagbok(string isbn, string tittel, string forfatter, int utgivelsesår, string fagområde)
        : base(isbn, tittel, forfatter, utgivelsesår) // refererer til superklassen som Fagbok arvet fra Bok
    {
        Fagområde = fagområde;     //setter egenskapen "Fagområde" til verdien som ble sendt inn som parameter "fagområdet"
    }                              // etter at Bok-konstruktøren er kalt. 

    // Overriding Abstract Methods
    public override void VisInfo()
    {
        Console.WriteLine($"[Fagbok] {Tittel} av {Forfatter} ({Utgivelsesår}) - Fagområde: {Fagområde}. ISBN {ISBN}");
    }


    // INTERFACE METHODS
    // public void LånUt() => Console.WriteLine($"Boken '{Tittel}' er lånt ut.");
   public void LaanUt()
    {
        if (BokInne)
        {
            BokInne = false;
            Console.WriteLine($"Fagboken '{Tittel}' er nå lånt ut.");
        }
        else
        {
            Console.WriteLine($"Fagboken '{Tittel}' er på utlån!");
        }
    }

    // public void LeverInn() => Console.WriteLine($"Boken '{Tittel}' er levert tilbake.");
    public void LeverInn()
    {
        if (!BokInne)
        {
            BokInne = true;
            Console.WriteLine($"Fagboken '{Tittel}' er nå levert tilbake.");
        }
        else
        {
            Console.WriteLine($"Fagboken '{Tittel}' er allerede levert tilbake.");
        }
    }

    public bool ErBokInne()
    {
        return BokInne;
    }
}    