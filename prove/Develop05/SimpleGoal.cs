public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {

        return true;
    }

    public override string GetStringRepresentation()
    {
        string goalRepresentation = $"{_name} | {_description} | worth {_points} points per completion.";
        return goalRepresentation;
    }
}