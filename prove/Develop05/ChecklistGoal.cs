public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints) : base(name, description, points)
    {
        _target = target;
        _bonusPoints = bonusPoints;
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

        return "";
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
}