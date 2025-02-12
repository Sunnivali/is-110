

Kalkulator kalk = new Kalkulator();

// For å fjerne, hvor filen er lagret, stien.
Console.Clear();

Console.WriteLine("Pleas enter value for first number: ");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Pleas enter value for second number: ");
double n2 = double.Parse(Console.ReadLine());


double resultat = kalk.CalcAddition(n1, n2);
Console.WriteLine($"Addisjon resultatet er: {resultat}");