public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.";
        _duration = 0;
    }

    public void Run()
    {
        // Ask user how long the breathing activity should run
        Console.Write($"How much time, in seconds, would you like to spend on this activity (program will round up to nearest 10)? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"This activity will run for {_duration} seconds.\n");
        // Give user 5 seconds before the breathing activity starts
        Console.WriteLine("Get ready...\n");
        ShowSpinner(5);
        // Run the breathing activity for the duration specified
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            Console.Write($"Breathe in...");
            ShowCountDown(4);
            Console.Write($"\nHold breath...");
            ShowCountDown(2);
            Console.Write($"\nBreathe out...");
            ShowCountDown(4);
            Console.WriteLine("\n");
        }
    }
}