using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Console.Write("What is your grade percentage? (Please input as an integer) ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        Console.WriteLine();

        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is: {letter}");

        Console.WriteLine();

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Review your notes and try again, you got this!");
        }
        
        Console.WriteLine();
    }
}