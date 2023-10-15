public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string type, string name, string description, int points, bool isComplete) : base(type, name, description, points)
    {
        isComplete = _isComplete;
    }

    public override void RecordEvent()
    {
        
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
            string goalRepresentation = $"\t{_name} | {_description} | worth {_points} points | incomplete";
            return goalRepresentation;
        }
    }
}