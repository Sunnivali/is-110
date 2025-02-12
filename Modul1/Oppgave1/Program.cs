class Program
{
    static void Main()
    {
        Handlekurv handlekurv = new Handlekurv(); // Lager et objekt handelkurv av klassen Handlekurv

        Console.Clear();
        Console.Write("Hvor mange varer vil du legge til? ");
        
        int antallVarer = int.Parse(Console.ReadLine());       // Parse er ein metode i systemklassen int

        for (int i = 0; i < antallVarer; i++)
        {
            Console.Write($"Skriv inn prisen på vare {i + 1}: ");
            decimal pris = decimal.Parse(Console.ReadLine());
            handlekurv.LeggTilVare(pris);
        }

        handlekurv.SkrivKvittering(); // Skriver ut kvittering

        if (handlekurv.BeregnTotal() > 500)
        {
            Console.WriteLine("Du får gratis frakt!");
             Console.Write("\n");
        }
    }
}