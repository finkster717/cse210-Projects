using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(); // Whitespace
        Console.WriteLine("Hello! Welcome to the Journal program!");
        Console.WriteLine(); // Whitespace

        // Declaring variables
        DateTime currentDateTime = DateTime.Now;
        Journal journal = new Journal();

        int userChoice = 0;
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
                Entry entry = new Entry();
                PromptGenerator newPrompt = new PromptGenerator();

                Console.WriteLine(); // Whitespace

                entry._prompt = newPrompt.GetRandomPrompt(); // Show a random prompt from Prompts.txt

                string newEntry = Console.ReadLine();
                
                entry._entry = newEntry;
                entry._date = currentDateTime.ToShortDateString();
                
                journal.AddEntry(entry);
                entry.Display();
                Console.WriteLine(); // Whitespace
            }
            else if (userChoice == 2)
            {
                Console.WriteLine(); // Whitespace
                journal.DisplayAll();
                Console.WriteLine(); // Whitespace
            }
            else if (userChoice == 3)
            {
                // Ask the user which file should load
                Console.Write("What is the name of the file would you like to load? ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (userChoice == 4)
            {
                // Let the user name a new journal file
                Console.Write("What would you like to name your new file? ");
                string fileName = Console.ReadLine();

                // Save the file
                journal.SaveToFile(fileName);
            }
        }
    }
} 