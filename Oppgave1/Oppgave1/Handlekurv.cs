using System;

class Handlekurv
{
    private decimal totalPris = 0; // Holder totalprisen

    public void LeggTilVare(decimal pris)
    {
        totalPris = totalPris + pris; // Legger til prisen i totalen        ein funksjon som legger til varepris til handlekorga sin totalpris
    }

    public decimal BeregnTotal()
    {
        return totalPris; // Returnerer totalprisen
    }

    public void SkrivKvittering()
    {
        Console.WriteLine("\nKvittering:");
        Console.WriteLine($"Totalpris: {totalPris:C}");

        if (totalPris > 500)
        {
            Console.WriteLine("Du får gratis frakt!");
        }
    }
}