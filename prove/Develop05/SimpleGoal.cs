public class SimpleGoal : Goal
{
    public SimpleGoal(string type, string name, string description, int points, bool isComplete) : base(type, name, description, points, isComplete)
    {
        
    }

    public override void RecordEvent()
    {
        
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
            string goalRepresentation = $"\t{_name} | {_description} | worth {_points} points | incomplete";
            return goalRepresentation;
        }
    }
}