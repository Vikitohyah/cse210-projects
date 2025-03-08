using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            int yourGuess = int.Parse(guessNumber);

            if (magicNumber > yourGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < yourGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        
        }                    
    
    }
}