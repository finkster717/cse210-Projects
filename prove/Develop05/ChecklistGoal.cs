public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string type, string name, string description, int points, int target, int bonusPoints, int amountCompleted, bool isComplete) : base(type, name, description, points, isComplete)
    {
        _target = target;
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        Console.WriteLine($"Your progress: {_amountCompleted}/{_target}");
        if (_amountCompleted == _target)
        {
            SetComplete();
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

    public override void SetComplete()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
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
        string goalDetails = $"{_type}|{_name}|{_description}|{_points}|{_target}|{_bonusPoints}|{_amountCompleted}|{_isComplete}";
        return goalDetails;
    }
}