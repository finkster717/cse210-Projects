// I exceeded requirements by making sure each reflecting activity question is unique.
// I also made sure that the user cannot exceed a duration in the reflecting activity
// that would cause repeat questions. This means the reflection activity can only go for
// a maximum of 90 seconds. I also added a goodbye animation when the user closes the 
// program.

class Program
{
    static void Main(string[] args)
    {
        // Initialize loop to run the program
        bool quit = false;
        while (quit == false)
        {
            // Clear the console and add whitespace for ease of reading
            Console.Clear();
            Console.WriteLine();
            // Present the menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start a breathing activity");
            Console.WriteLine("\t2. Start a listing activity");
            Console.WriteLine("\t3. Start a reflecting activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Please type the number associated with your choice from the menu: ");
            // Get the user's choice of activity and run that activity
            Activity activity = new Activity();
            string userChoice = activity.GetUserChoice();
            if (userChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }
            else if (userChoice == "2")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                Console.WriteLine($"\nYou listed {listingActivity.GetCount()} responses.");
                listingActivity.DisplayEndingMessage();
            }
            else if (userChoice == "3")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }
            else if (userChoice == "4")
            {
                Console.Write("\nGoodbye\t");
                int count = 6;
                int timer = 0;
                while (timer < count)
                {
                    Console.Write("o/");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write("o7");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    timer ++;
                }
                quit = true;
            }
        }
    }
}