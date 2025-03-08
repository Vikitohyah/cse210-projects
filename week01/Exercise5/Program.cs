using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int square = SquareNumber(favoriteNumber);
        DisplayResult(userName, square);
        
    }

    static void DisplayWelcome()
    { 
        Console.WriteLine("Welcome to the Program!");
    }
        
    static string PromptUserName()
    { 
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    { 
        Console.WriteLine("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int favoriteNumber = int.Parse(userNumber);

        return favoriteNumber;
    }

    static int SquareNumber(int favoriteNumber)
    { 
        int square = favoriteNumber * favoriteNumber;
        return square;
    }

    static void DisplayResult(string userName, int square)
    { 
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}