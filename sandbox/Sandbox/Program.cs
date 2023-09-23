using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        List<string> _prompts = new List<string>();
        string filename = "Prompts.txt";

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            line.Split("|");
            _prompts.Add(line);
        }

        void ShowPrompts()
        {
            foreach (string line in _prompts)
            {
                Console.WriteLine(line);
            }
        }

        ShowPrompts();

        Console.WriteLine("Hello! Welcome to the Journal program!");
        while (userChoice != 5)
        {
            Console.WriteLine("Please make a selection by typing the number associated with your choice from this list...");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string userInput = Console.ReadLine();
            userChoice = int.Parse(userInput);
            
            if (userChoice == 1)
            {
                Console.WriteLine(); // Placeholder for where the prompt will go when I have it figured out...
                string entry1 = Console.ReadLine();
                Console.WriteLine($"Your entry: {entry1}");
            }
        }
        
    }
}