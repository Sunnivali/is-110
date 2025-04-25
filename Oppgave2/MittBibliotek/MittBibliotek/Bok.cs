// Abstrakt klasse Bok
// Basisklasse for bøker som tvinger subklasser til å implementere VisInfo-metoden.
abstract class Bok
{
    public string ISBN { get; set; }
    public string Tittel { get; set; }
    public string Forfatter { get; set; }
    public int Utgivelsesår { get; set; }

    public Bok(string isbn, string tittel, string forfatter, int utgivelsesår)  // Konstruktør for å sette verdier på bokens egenskaper.
    {
        ISBN = isbn;
        Tittel = tittel;
        Forfatter = forfatter;
        Utgivelsesår = utgivelsesår;
    }

    public abstract void VisInfo(); // Abstrakt metode som må implementeres i subklasser for å vise informasjon om boken.
}

// Grensesnitt for lånefunksjoner
// Definerer metodene LånUt og LeverInn som må implementeres i klasser som bruker dette grensesnittet.
interface IBokFunksjoner
{
    void LånUt(); // Metode for å låne ut en bok
    void LeverInn(); // Metode for å levere inn en bok
}