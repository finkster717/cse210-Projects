public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;
    private bool _isComplete;

    public ChecklistGoal(string type, string name, string description, int points, int target, int bonusPoints, int amountCompleted, bool isComplete) : base(type, name, description, points)
    {
        _target = target;
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted;
        isComplete = _isComplete;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        Console.WriteLine($"Your progress: {_amountCompleted}/{_target}");
        if (_amountCompleted == _target)
        {
            IsComplete();
        }
    }

    public override int GetPoints()
    {
        if (_isComplete == true)
        {
            return _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override void IsComplete()
    {
        _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete == true)
        {
            string goalRepresentation = $"\t{_name} | {_description} | worth {_points} points | COMPLETE";
            return goalRepresentation;
        }
        else
        {
            string goalRepresentation = $"\t{_name} | {_description} | worth {_points} points | completed: {_amountCompleted}/{_target}";
            return goalRepresentation;
        }
    }

    public override string GetDetailsString()
    {
        string goalDetails = $"Name: {_name} | Description: {_description} | Points Per Completion: {_points} | Points On Complete: {_bonusPoints}";
        return goalDetails;
    }
}