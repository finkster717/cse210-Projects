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
        // Get the user's choice
        string userChoice = Console.ReadLine();
        return userChoice;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name.ToLower()}.\n");
        Console.WriteLine($"{_description}\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed a {_duration} second {_name.ToLower()}.");
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
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
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