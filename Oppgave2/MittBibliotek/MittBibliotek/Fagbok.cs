class Fagbok : Bok, IBokFunksjoner // Klasse for fagbøker, arver fra Bok og implementerer IBokFunksjoner
{
    public string Fagområde { get; set; } // Spesifikt fagområde for fagboken


 // Konstruktør som sender felles data til basisklassen og setter fagområde
    public Fagbok(string isbn, string tittel, string forfatter, int utgivelsesår, string fagområde)
        : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Fagområde = fagområde;
    }

    public override void VisInfo()   // Implementasjon av abstrakt metode fra Bok
    {
        Console.WriteLine($"[Fagbok] {Tittel} av {Forfatter} ({Utgivelsesår}) - Fagområde: {Fagområde}");
    }

    public void LånUt() => Console.WriteLine($"Boken '{Tittel}' er lånt ut.");     // Metode for å låne ut boken
    public void LeverInn() => Console.WriteLine($"Boken '{Tittel}' er levert tilbake.");     // Metode for å levere inn boken
}