// Klasse for romaner, arver fra Bok og implementerer IBokFunksjoner
class Roman : Bok, IBokFunksjoner
{
    public string Sjanger { get; set; } // Sjanger for romanen (f.eks. krim, romantikk)


    // Konstruktør: sender felles data til Bok og setter sjanger
    public Roman(string isbn, string tittel, string forfatter, int utgivelsesår, string sjanger)
        : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Sjanger = sjanger;
    }

    public override void VisInfo()  // Viser info om romanen (implementerer abstrakt metode fra Bok)
    {
        Console.WriteLine($"[Roman] {Tittel} av {Forfatter} ({Utgivelsesår}) - Sjanger: {Sjanger}");
    }

    public void LånUt() => Console.WriteLine($"Boken '{Tittel}' er lånt ut.");  // Låne ut romanen
    public void LeverInn() => Console.WriteLine($"Boken '{Tittel}' er levert tilbake.");  // Levere inn romanen
}