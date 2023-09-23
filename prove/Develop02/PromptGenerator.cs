using System.ComponentModel;
using System.Linq.Expressions;

public class PromptGenerator
{   
    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>();
        string filename = "Prompts.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            line.Split("?");
            _prompts.Add(line);
        }

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[promptIndex];
        Console.WriteLine(randomPrompt);

        return randomPrompt;
    }
}