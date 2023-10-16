// added an animation at the end when the user closes the program, other than that program runs as specified in requirements

class Program
{
    static void Main(string[] args)
    {
        // Instanciate goal manager and start the program
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
