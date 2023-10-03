public class Assignment
{
    protected string _studentName;
    protected string _topic;

    // constructing constructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}\n";
    }
}