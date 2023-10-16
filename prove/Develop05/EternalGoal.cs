public class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points, false)
    {
        
    }

    public override void RecordEvent()
    {

    }

    public override void SetComplete()
    {

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        string goalRepresentation = $"\t{_name} | {_description} | worth {_points} points per completion.";
        return goalRepresentation;
    }
}