public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        
    }

    public void Start()
    {
        bool quit = false;
        while (quit == false)
        {
            // Clear the console and add whitespace
            Console.Clear();
            Console.WriteLine();

            // Instanciate goal manager and display
            DisplayPlayerInfo();
            Console.WriteLine(); // Whitespace

            // Display the menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Please type the number associated with your selection here: >");
            string userInput = Console.ReadLine();
            Console.WriteLine(); // WhiteSpace

            if (int.Parse(userInput) == 1)
            {
                CreateGoal();
            }
            else if (int.Parse(userInput) == 2)
            {
                ListGoalDetails();
                Console.WriteLine("Press ENTER when finished");
                Console.ReadLine();
            }
            else if (int.Parse(userInput) == 3)
            {
                SaveGoals();
            }
            else if (int.Parse(userInput) == 4)
            {
                LoadGoals();
            }
            else if (int.Parse(userInput) == 5)
            {
                ListGoalDetails();
                Console.WriteLine();
                RecordEvent();
            }
            else if (int.Parse(userInput) == 6)
            {   
                int count = 5;
                int timer = 0;
                while (timer < count)
                {
                    GoodbyeAnimation();
                    timer ++;
                }
                quit = true;
            }

            Console.Clear();
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            int goalIndex = _goals.IndexOf(goal) + 1;
            string line = goalIndex.ToString() + ". " + goal.GetStringRepresentation();
            Console.WriteLine(line);
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? >");
        int goalType = int.Parse(Console.ReadLine());
        Console.Write("What would you like to name your goal? >");
        string goalName = Console.ReadLine();
        Console.Write("Please provide a short description of your goal: >");
        string goalDescription = Console.ReadLine();
        Console.Write("How many points should be gained by completing this goal? >");
        int goalPoints = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal("simple", goalName, goalDescription, goalPoints, false));
        }
        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal("eternal", goalName, goalDescription, goalPoints));
        }
        else if (goalType == 3)
        {
            Console.Write("How many times would you like to complete this goal? >");
            int target = int.Parse(Console.ReadLine());
            Console.Write($"How many bonus points for completing the goal that many times? >");
            int bonusPoints = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal("checklist", goalName, goalDescription, goalPoints, target, bonusPoints, 0, false));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Please type the number associated with your choice...");
        Console.Write("Which goal would you like to report progress on? ");
        int completedGoalIndex = int.Parse(Console.ReadLine()) - 1;
        foreach (Goal goal in _goals)
        {
            if (_goals.IndexOf(goal) == completedGoalIndex)
            {
                string goalType = goal.GetGoalType();
                if (goalType == "simple")
                {
                    if (goal.IsComplete() == true)
                    {
                        Console.WriteLine("That goal is already marked complete.\nPress ENTER to return to the main menu.");
                        Console.ReadLine();
                    }
                    else
                    {
                        goal.SetComplete();
                        AddPoints(goal.GetPoints());
                        Console.WriteLine("CONGRATULATIONS!");
                        Console.WriteLine($"Your {goalType} goal has been marked complete.");
                        Console.WriteLine("\nPlease press ENTER when you are ready to return to the main menu");
                    }
                }
                else if (goalType == "eternal")
                {
                    AddPoints(goal.GetPoints());
                    Console.WriteLine("CONGRATULATIONS!");
                    Console.WriteLine($"Your {goalType} goal's points have been added to your score.");
                    Console.WriteLine("\nPlease press ENTER when you are ready to return to the main menu.");
                }
                else if (goalType == "checklist")
                {
                    if (goal.IsComplete() == true)
                    {
                        Console.WriteLine("That goal is already marked complete.\nPress ENTER to return to the main menu.");
                        Console.ReadLine();
                    }
                    else
                    {
                        AddPoints(goal.GetPoints());
                        goal.RecordEvent();
                        if (goal.IsComplete() == true)
                        {
                            AddPoints(goal.GetPoints());
                        }
                        Console.WriteLine("CONGRATULATIONS!");
                        Console.WriteLine($"Your progress toward your {goalType} goal has been recorded.");
                        Console.WriteLine("\nPlease press ENTER when you are ready to return to the main menu.");
                    }
                }
            }
        }
    }

    public void AddPoints(int pointsToAdd)
    {
        _score += pointsToAdd;
    }

    public void SaveGoals()
    {
        Console.Write("What would you like to name your save file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
            outputFile.WriteLine($"{goal.GetDetailsString()}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of your save file: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines.First());
        lines.Skip(1);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string type = parts[0];
            if (type == "checklist")
            {
                LoadChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
            }
            else if (type == "simple")
            {
                LoadSimpleGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            }
            else if (type == "eternal")
            {
                LoadEternalGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]));
            }
            else
            {
                continue;
            }
        }
    }

    public void LoadSimpleGoal(string type, string name, string description, int points, bool isComplete)
    {
        SimpleGoal simpleGoal = new SimpleGoal(type, name, description, points, isComplete);
        _goals.Add(simpleGoal);
    }

    public void LoadEternalGoal(string type, string name, string description, int points)
    {
        EternalGoal eternalGoal = new EternalGoal(type, name, description, points);
        _goals.Add(eternalGoal);
    }

    public void LoadChecklistGoal(string type, string name, string description, int points, int target, int bonusPoints, int amountCompleted, bool isComplete)
    {
        ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, target, bonusPoints, amountCompleted, isComplete);
        _goals.Add(checklistGoal);
    }

    static void GoodbyeAnimation()
    {
        Console.Clear();
        Console.WriteLine("\tGoodbye!");
        Console.WriteLine("\t" + @"     /");
        Console.WriteLine("\t" + @"   O|");
        Console.WriteLine("\t" + @"  /||");
        Console.WriteLine("\t" + @" / ||");
        Console.WriteLine("\t" + @"   /\");
        Console.WriteLine("\t" + @"  /  \");
        Console.WriteLine("\t" + @" /    \");
        Thread.Sleep(200);
        Console.Clear();
        Console.WriteLine("\tGoodbye!");
        Console.WriteLine("\t" + @"    |");
        Console.WriteLine("\t" + @"   O|");
        Console.WriteLine("\t" + @"  /||");
        Console.WriteLine("\t" + @" / ||");
        Console.WriteLine("\t" + @"   /\");
        Console.WriteLine("\t" + @"  /  \");
        Console.WriteLine("\t" + @" /    \");
        Thread.Sleep(200);
        Console.Clear();
        Console.WriteLine("\tGoodbye!");
        Console.WriteLine("\t" + @"   \");
        Console.WriteLine("\t" + @"   O|");
        Console.WriteLine("\t" + @"  /||");
        Console.WriteLine("\t" + @" / ||");
        Console.WriteLine("\t" + @"   /\");
        Console.WriteLine("\t" + @"  /  \");
        Console.WriteLine("\t" + @" /    \");
        Thread.Sleep(200);
        Console.Clear();
        Console.WriteLine("\tGoodbye!");
        Console.WriteLine("\t" + @"    |");
        Console.WriteLine("\t" + @"   O|");
        Console.WriteLine("\t" + @"  /||");
        Console.WriteLine("\t" + @" / ||");
        Console.WriteLine("\t" + @"   /\");
        Console.WriteLine("\t" + @"  /  \");
        Console.WriteLine("\t" + @" /    \");
        Thread.Sleep(200);
    }

}