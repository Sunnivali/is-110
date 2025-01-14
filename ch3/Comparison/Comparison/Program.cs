// Comparing integers using if statments, equality operators
// and relational operators.

using System;

class Comparison
{

static void Main()
{
    Console.Clear();
    Console.Write("Enter first integer:");
    int number1 = int.Parse(Console.ReadLine());


    Console.Write("Enter second integer:");
    int number2 = int.Parse(Console.ReadLine());

    if (number1 == number2)
    {
        Console.WriteLine($"{number1} == {number2}");
    }

    if (number1 != number2)
    {
        Console.WriteLine($"{number1} != {number2}");
    }

    if (number1 < number2)
    {
        Console.WriteLine($"{number1} < {number2}");
    }

    if (number1 > number2)
    {
        Console.WriteLine($"{number1} > {number2}");
    }

    if (number1 <= number2)
    {
        Console.WriteLine($"{number1} <= {number2}");
    }

    if (number1 >= number2)
    {
        Console.WriteLine($"{number1} >= {number2}");
    }
}
}