public class ListingActivity : Activity
{
    private string _prompt;
    private int _count;

    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list your answers to a random prompt.";
        _duration = 0;
    }

    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>();
        string filename = "ListingActivityPrompts.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            line.Split("?");
            _prompts.Add(line);
        }

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[promptIndex];

        return randomPrompt;
    }

    public int GetCount()
    {
        return _count;
    }

    public void Run()
    {
        // Ask user how long the listing activity should run
        Console.Write($"How much time, in seconds, would you like to spend on this activity (30 or more recommended)? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"This activity will run for {_duration} seconds.\n");
        // Get a random prompt ready
        _prompt = GetRandomPrompt();
        // Show user the prompt and give 9 seconds to prepare
        Console.WriteLine("List as many responses as you can to the given prompt:");
        Console.WriteLine($"---{_prompt}---");
        Console.Write("You may begin in: ");
        ShowCountDown(9);
        Console.Write("\b ");
        Console.WriteLine("Begin");
        // Begin the listing activity for the duration specified
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _count ++;
        }
    }
}