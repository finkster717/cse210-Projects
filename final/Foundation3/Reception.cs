public class Reception : Event
{
    private string _registrationEmail;

    public Reception(string title, string type, string description, string date, string time, Address address, string registrationEmail) : base(title, type, description, date, time, address)
    {
        _registrationEmail = registrationEmail;
    }

    public string GetEmail()
    {
        return _registrationEmail;
    }

    public override string GetFullDetails()
    {
        return $"{_eventTitle} | {_eventType}\n{_description}\n{_date} at {_time}\n{_address}\nEmail for RSVP: {_registrationEmail}";
    }

    public override void DisplayMarketingMessage()
    {
        Console.WriteLine($"Hello! I am excited to invite you to {_eventTitle}, where you will be able to participate in {_description.ToLower()}. Please RSVP by emailing {_registrationEmail}. The event will take place on {_date} at {_time}. I look forward to seeing you there!\n{_address.GetAddressString()}");
    }
}