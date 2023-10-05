public class Activity
{
    protected string _name;
    protected string _description;
    protected string _duration;

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("You're about to waste some of your time on this activity which does nothing to solve your life's problems...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Congratulations! You've wasted a significant portion of your time today on this activity!");
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }
}