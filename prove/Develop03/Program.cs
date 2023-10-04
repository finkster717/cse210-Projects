using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference reference1 = new Reference("John",3,16);
        Scripture scripture1 = new Scripture(reference1,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        Console.WriteLine($"{reference1.GetDisplayText()}  {scripture1.GetDisplayText()}\n");
        Console.WriteLine("Press enter to continue or type \"quit\" to finish...");
        
        bool completelyHidden = false;
        while (completelyHidden == false)
        {    
            string userInput = Console.ReadLine();
            if (userInput.ToLower() != "quit")
            {
                string newScripture = scripture1.HideRandomWords(2);
                Scripture hiddenScripture = new Scripture(reference1, newScripture);
                Console.Clear();
                Console.WriteLine($"{reference1.GetDisplayText()}  {hiddenScripture.GetDisplayText()}\n");
                Console.WriteLine("Press enter to continue or type \"quit\" to finish...");
                completelyHidden = hiddenScripture.IsCompletelyHidden();
            }
            else if (userInput.ToLower() == "quit")
            {
                break;
            }
        }
    }
}