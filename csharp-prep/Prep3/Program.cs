using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int userGuess = 0;
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userInputGuess = Console.ReadLine();
            userGuess = int.Parse(userInputGuess);

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        Console.WriteLine();
    }
}