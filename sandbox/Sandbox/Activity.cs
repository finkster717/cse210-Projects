using System.Net;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public string GetUserChoice()
    {
        // Interpret from user input the name and description of the desired activity
        string userChoice = Console.ReadLine();
        if (userChoice == "1")
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        else if (userChoice == "2")
        {
            _name = "Listing Activity";
            _description = "This activity will...";
        }
        else if (userChoice == "3")
        {
            _name = "Reflecting Activity";
            _description = "This activity will...";
        }
        return userChoice;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!!");
        Console.WriteLine($"You have completed a {_duration} second breathing activity.");
        Console.WriteLine("Returning to the main menu...");
        ShowSpinner(7);
    }

    public void ShowSpinner(int seconds)
    {
        int timer = 0;
        while (timer < seconds)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b\b");
            timer ++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        int timer = seconds;
        while (timer > 0)
        {
            Console.Write(timer);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            timer --;
        }
    }
}