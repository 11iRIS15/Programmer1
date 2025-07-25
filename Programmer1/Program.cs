using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age in years: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 1 && age <= 120)
        {
            Console.WriteLine($"You are {age * 12} months old.");
        }
        else
        {
            Console.WriteLine("Invalid age. Age must be between 1 and 120.");
        }
    }
}

