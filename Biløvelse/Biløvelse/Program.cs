// // Modul 3, Lab øvelser
// // Øvelse 2

// // opprette et objekt
Bil minbil = new Bil();

// //  sette verdier
minbil.SetMerke("Volvo");
minbil.SetModell("V40");
minbil.SetÅr("2012");

// //  henter verdier
string minBilMerke = minbil.GetMerke();
string minBilModell = minbil.GetModell();
string minBilÅr = minbil.GetÅr();

// // for å mindre når man skriver ut verdiene. Ryddare.
Console.Clear();
// // skrive ut verdier
Console.WriteLine($"Min bil er merke: {minBilMerke}, modell: {minBilModell}, år: {minBilÅr}");




// // // Øvelse 1:

// int x, y, z, resultat;
// Console.WriteLine("Pleas enter value for first integer:");
// x = int.Parse(Console.ReadLine());
// Console.WriteLine("Pleas enter value for second integer:");
// y = int.Parse(Console.ReadLine());
// Console.WriteLine("Pleas enter value for third integer:");
// z = int.Parse(Console.ReadLine());

// resultat = x * y * z;
// Console.Clear();
// Console.WriteLine($"Mulitiplikasjonsresultstet er: {resultat}");




// // Øvelse 3:
// // For å kunne kjøre de ulike øvelsene må de andre øvelsene.
// //  vær i grønnt/kommentar.

// Kalkulator kalk = new Kalkulator();

// // For å fjerne, hvor filen er lagret, stien.
// Console.Clear();

// Console.WriteLine("Pleas enter value for first number: ");
// double n1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Pleas enter value for second number: ");
// double n2 = double.Parse(Console.ReadLine());


// double resultat = kalk.CalcAddition(n1, n2);
// Console.WriteLine($"Addisjon resultatet er: {resultat}");