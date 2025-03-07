class Program
{
    static void Main()
    {
        Handlekurv handlekurv = new Handlekurv(); // Lager et objekt av klassen Handlekurv, for å kunne bruke metodene i Handlekurv
        
        Console.Clear(); 
        Console.Write("Hvor mange varer vil du legge til? "); // Skriver ute en melding uten å hoppe til ny linje.
        
        int antallVarer = int.Parse(Console.ReadLine()); // Lar brukeren skrive inn et tall, Konvertere brukerens input fra teskt til et heltall    

        for (int i = 0; i < antallVarer; i++) // Løkka kjører like mange ganger som antall varer brukeren skrev inn
        {
            Console.Write($"Skriv inn prisen på vare {i + 1}: "); 
            decimal pris = decimal.Parse(Console.ReadLine()); // Leser inn brukerens input, og konverterer teksten til et desimaltall
            handlekurv.LeggTilVare(pris); // Legger prisen til totalprisen, kaller metoden LeggTilVare(pris) i Handlekurv-klassen
        }

        handlekurv.SkrivKvittering(); // Skriver ut kvittering

        if (handlekurv.BeregnTotal() > 500)  // Henter totalprisen, hvis totalen er mer en 500, får brukeren gratis frakt
        {
            Console.WriteLine("Du får gratis frakt!");
             Console.Write("\n");
        }
    }
}