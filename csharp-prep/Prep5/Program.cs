using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        DisplayWelcomeMessage();

        // Get user name
        string userName = PromptUserName();

        // Get user number
        int userNumber = PromptUserNumber();

        // Calculate square of number
        int squaredNumber = SquareNumber(userNumber);

        // Display result
        DisplayResult(userName, squaredNumber);
    }

    // Display welcome message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Prompt user for name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Prompt user for number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Calculate square of number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Display result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}