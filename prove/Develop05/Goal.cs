public abstract class Goal
{
    // Declaring member variables
    protected string _name;
    protected string _description;
    protected int _points;

    // Constructing constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Declaring abstract methods
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    // Declaring virtual method, will be overridden by ChecklistGoal
    public virtual string GetDetailsString()
    {
        string goalDetails = $"";
        return goalDetails;
    }
}