public class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        
    }

    public override void RecordEvent()
    {

    }

    public override void IsComplete()
    {

    }

    public override string GetStringRepresentation()
    {
        string goalRepresentation = $"\t{_name} | {_description} | worth {_points} points per completion.";
        return goalRepresentation;
    }
}