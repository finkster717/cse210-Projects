using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("Running", "10/13/2023", 30, 3));
        activities.Add(new Cycling("Cycling", "10/12/2023", 120, 25));
        activities.Add(new Swimming("Swimming", "10/14/2023", 30, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}");
        }
    }
}