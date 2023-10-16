public abstract class Goal
{
    // Declaring member variables
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    // Constructing constructor
    public Goal(string type, string name, string description, int points, bool isComplete)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    // Declaring abstract methods
    public abstract void RecordEvent();
    public abstract void SetComplete();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    // Declaring virtual method, will be overridden by ChecklistGoal
    public virtual string GetDetailsString()
    {
        string goalDetails = $"{_type}|{_name}|{_description}|{_points}|{_isComplete}";
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