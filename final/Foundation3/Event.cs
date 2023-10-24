public abstract class Event
{
    protected string _eventTitle;
    protected string _eventType;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string type, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _eventType = type;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_eventTitle}\n{_description}\n{_date} at {_time}";
    }

    public virtual string GetFullDetails()
    {
        return $"{_eventTitle} | {_eventType}\n{_description}\n{_date} at {_time}\n{_address}";
    }

    public string GetShortDescription()
    {
        return $"{_eventType} | {_eventTitle} | {_date}";
    }

    public virtual void DisplayMarketingMessage()
    {
        Console.WriteLine($"Hello! I am excited to invite you to {_eventTitle}, where you will be able to participate in {_description}. The event will take place on {_date} at {_time}. I look forward to seeing you there!\n{_address.GetAddressString()}");
    }
}