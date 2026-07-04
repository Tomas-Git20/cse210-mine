using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        // Generate a random magic number between 1 and 100
        int magicNumber = randomGenerator.Next(1, 101);

        // Ask the user for their first guess
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        // Keep looping until the user guesses correctly
        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        // The user guessed correctly
        Console.WriteLine("You guessed it!");
    }
}