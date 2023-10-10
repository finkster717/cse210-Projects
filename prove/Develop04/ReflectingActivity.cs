// I exceeded requirements by making sure each reflecting activity question is unique.
// I also made sure that the user cannot exceed a duration in the reflecting activity
// that would cause repeat questions. This means the reflection activity can only go for
// a maximum of 90 seconds.

public class ReflectingActivity : Activity
{
    private string _prompt;
    private string _question;
    private List<string> _usedQuestions = new List<string>();
    private bool _questionUnique;

    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
        _usedQuestions.Add("This is to keep the list from being null.");
    }

    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>();
        string filename = "ReflectingActivityPrompts.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            line.Split(".");
            _prompts.Add(line);
        }

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[promptIndex];

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        List<string> _questions = new List<string>();
        string filename = "ReflectingActivityQuestions.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            line.Split("?");
            _questions.Add(line);
        }

        Random random = new Random();
        int questionIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[questionIndex];

        return randomQuestion;
    }

    public void IsQuestionUnique()
    {
        if (_usedQuestions.Contains(_question) == true)
        {
            _questionUnique = false;
            while (_questionUnique == false)
            {
                _question = GetRandomQuestion();
                if (_usedQuestions.Contains(_question) == false)
                {
                    _questionUnique = true;
                }
                else
                {
                    continue;
                }
            }
        }
    }

    public void Run()
    {
        // Ask the user how long they would like to spend on the activity
        Console.Write($"How much time, in seconds, would you like to spend on this activity (30 or more recommended, cannot exceed 90)? ");
        _duration = int.Parse(Console.ReadLine());
        // If the user types in a duration that exceeds maximum allowed, set duration to 90
        if (_duration > 90)
        {
            _duration = 90;
        }
        Console.WriteLine($"This activity will run for {_duration} seconds.\n"); 
        // Get a random prompt from the list of prompts
        _prompt = GetRandomPrompt();   
        // Give user 5 seconds before the reflecting activity starts
        Console.WriteLine("Get ready...\n");
        ShowSpinner(5);
        // Present the user with the random prompt and instruct on how to proceed
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{_prompt}---");
        Console.WriteLine("When you have something in mind, press ENTER to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions related to this experience.");
        // Give the user 9 seconds before proceeding
        ShowCountDown(9);
        Console.Write("\b");
        Console.WriteLine("Begin\n");
        // Get random questions and present them for 10 seconds each
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            _question = GetRandomQuestion();
            // Check if question is unique
            IsQuestionUnique();
            Console.Write($"{_question} ");
            _usedQuestions.Add(_question);
            ShowSpinner(10);
            Console.WriteLine();
        }
    }
}