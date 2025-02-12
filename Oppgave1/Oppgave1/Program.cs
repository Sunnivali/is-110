class Program
{
    static void Main()
    {
        Handlekurv handlekurv = new Handlekurv(); // Lager et objekt handelkurv av klassen Handlekurv

        Console.Write("Hvor mange varer vil du legge til? ");
        // int antallVarer = int.Parse(Console.ReadLine());

        // for (int i = 0; i < antallVarer; i++)
        // {
        //     Console.Write($"Skriv inn prisen på vare {i + 1}: ");
        //     decimal pris = decimal.Parse(Console.ReadLine());
        //     handlekurv.LeggTilVare(pris);
        // }

        handlekurv.SkrivKvittering(); // Skriver ut kvittering
    }
}