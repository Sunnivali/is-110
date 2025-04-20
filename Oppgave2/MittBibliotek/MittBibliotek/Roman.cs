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