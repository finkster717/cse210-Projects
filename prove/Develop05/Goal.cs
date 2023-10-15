public abstract class Goal
{
    // Declaring member variables
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;

    // Constructing constructor
    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    // Declaring abstract methods
    public abstract void RecordEvent();
    public abstract void IsComplete();
    public abstract string GetStringRepresentation();

    // Declaring virtual method, will be overridden by ChecklistGoal
    public virtual string GetDetailsString()
    {
        string goalDetails = $"Name: {_name} | Description: {_description} | Points On Complete: {_points} | ";
        return goalDetails;
    }

    public string GetGoalType()
    {
        return _type;
    }

    public virtual int GetPoints()
    {
        return _points;
    }
}