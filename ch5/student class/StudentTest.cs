//  Fig. 5.6: StudentTest.cs
//Create and test Student objects.
using System;

public class StudentTest
{
    static void Main()
    {
        Student student1 = new Student("Jane Green", 93);
        Student student2 = new Student("John Blue", 72);

        Console.Clear();
        Console.Write($"{student1.Name}'s letter grade equivalent of ");
        Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");
        Console.Write($"{student2.Name}'s letter grade equivalent of ");
        Console.WriteLine($"{student2.Average} is {student1.LetterGrade}");
    }
}