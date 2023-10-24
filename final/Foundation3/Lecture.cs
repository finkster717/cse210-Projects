public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string type, string description, string date, string time, Address address, string speaker, int capacity) : base(title, type, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

        public override string GetFullDetails()
    {
        return $"{_eventTitle} | {_eventType}\n{_description}\n{_date} at {_time}\n{_address}\nSpeaker: {_speaker}\nMaximum Occupancy: {_capacity}";
    }

    public override void DisplayMarketingMessage()
    {
        Console.WriteLine($"Hello! I am excited to invite you to {_eventTitle}, where you will be able to participate in {_description.ToLower()}. The event will take place on {_date} at {_time}. You will be thrilled to hear from {_speaker}, but don't be late! The maximum occupancy for this lecture is {_capacity}. I look forward to seeing you there!\n{_address.GetAddressString()}");
    }
}