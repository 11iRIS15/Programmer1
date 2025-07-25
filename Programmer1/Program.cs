using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your first name: "); //asked the user
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: "); //asked the user
        string lastName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)) //check if the name is empty
        {
            Console.WriteLine("Error: First name and last name cannot be empty."); //display if error
        }
        else
        {
            Console.WriteLine($"Your full name is: {firstName} {lastName}"); //display if it is successful
        }
    }
}
