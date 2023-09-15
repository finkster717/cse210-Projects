using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        static void main()
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int favNumber = PromptUserNumber();
            int squared = SquareNumber(favNumber);

            DisplayResult(squared, userName);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int favNumber = int.Parse(userInput);
            return favNumber;
        }

        static int SquareNumber(int favNumber)
        {
            int squared = favNumber * favNumber;
            return squared;
        }

        static void DisplayResult(int squared, string userName)
        {
            Console.WriteLine($"{userName}, the square of your number is {squared}");
        }

        main();

        Console.WriteLine();
    }
}