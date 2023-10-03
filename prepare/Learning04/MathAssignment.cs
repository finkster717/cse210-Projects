public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // constructing constructor
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()}{_textbookSection} {_problems}";
    }
}