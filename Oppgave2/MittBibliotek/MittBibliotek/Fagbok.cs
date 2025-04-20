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