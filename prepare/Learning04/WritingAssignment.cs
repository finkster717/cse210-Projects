public class WritingAssignment : Assignment
{
    private string _title;

    // constructing constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()}{_title}";
    }
}