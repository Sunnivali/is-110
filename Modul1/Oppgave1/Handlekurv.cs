using System;

class Handlekurv        // Definerer klassen, med et felt totalpris, som lagre summen av alle varene
{
    private decimal totalPris = 0; // Holder totalprisen
    public void LeggTilVare(decimal pris)       // tar inn en parameter av typen decimal, som representere prisen på ein vare
    {
        totalPris = totalPris + pris; // Legger til prisen i totalen        
    }

    public decimal BeregnTotal()
    {
        return totalPris; // Returnerer totalprisen
    }

    public void SkrivKvittering()
    {
        Console.WriteLine("\nKvittering:"); // Lager ei tom linje for oversikten sin del
        Console.WriteLine($"Totalpris: {totalPris} kr");  // Skriver ut totalprisen
        Console.Write("\n"); // lager en tom linje for lesbarhet
    }
}