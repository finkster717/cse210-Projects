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

            }
            else if (int.Parse(userInput) == 4)
            {

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
                    goal.IsComplete();
                    AddPoints(goal.GetPoints());
                    Console.WriteLine("CONGRATULATIONS!");
                    Console.WriteLine($"Your {goalType} goal has been marked complete.");
                    Console.WriteLine("\nPlease press ENTER when you are ready to return to the main menu");
                }
                else if (goalType == "eternal")
                {
                    Console.WriteLine("Still working on this part, will not be updated...");
                    Console.WriteLine("\nPlease press ENTER when you are ready to return to the main menu");
                }
                else if (goalType == "checklist")
                {
                    AddPoints(goal.GetPoints());
                    goal.RecordEvent();
                    AddPoints(goal.GetPoints());
                    Console.WriteLine("CONGRATULATIONS!");
                    Console.WriteLine($"Your progress toward your {goalType} goal has been recorded.");
                    Console.WriteLine("\nPlease press ENTER when you are ready to return to the main menu");
                }
            }
        }
    }

    public void AddPoints(int pointsToAdd)
    {
        _score += pointsToAdd;
    }

/* Figure this out later...
    public void SaveGoals()
    {
        Console.Write("What would you like to name your save file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
        
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }


    public void LoadGoals()
    {

    }
*/

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