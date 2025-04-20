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

    public abstract void VisInfo(); // Må implementeres i subklasser
}

// Grensesnitt for lånefunksjoner
interface IBokFunksjoner
{
    void LånUt();
    void LeverInn();
}