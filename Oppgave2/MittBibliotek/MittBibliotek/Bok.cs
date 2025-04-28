// Abstrakt klasse Bok
abstract class Bok
{
    // Public Properties
    public string ISBN { get; set; }    // leser og henter verdi
    public string Tittel { get; set; }
    public string Forfatter { get; set; }
    public int Utgivelsesår { get; set; }
    public bool BokInne { get; set; } = true;   // brukes for å teste om noe er true eller false. Ei bok er allitid inne i utgangspunktet

    // Constructor
    public Bok(string isbn, string tittel, string forfatter, int utgivelsesår) // brukes for å sette starverdier
    {
        ISBN = isbn;
        Tittel = tittel;
        Forfatter = forfatter;
        Utgivelsesår = utgivelsesår;
    }

    // Abstract Methods
    public abstract void VisInfo(); // Må implementeres i subklasser, skal arves av andre klasser
}

// Grensesnitt for lånefunksjoner
interface IBokFunksjoner // definerer et interface, en list med krav
{
    bool ErBokInne();       //metode ErBookInne, returneren en bool.
    void LaanUt();
    void LeverInn();
}