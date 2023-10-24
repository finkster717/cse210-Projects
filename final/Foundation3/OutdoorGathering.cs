public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string type, string description, string date, string time, Address address, string weatherForecast) : base(title, type, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetForecast()
    {
        return _weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{_eventTitle} | {_eventType}\n{_description}\n{_date} at {_time}\n{_address}\nWeather Forecast: {_weatherForecast}";
    }

    public override void DisplayMarketingMessage()
    {
        Console.WriteLine($"Hello! I am excited to invite you to {_eventTitle}, where you will be able to participate in {_description.ToLower()}. If attending, please arive on {_date} at {_time}. As this is an outdoor event, please dress according to the weather. Currently, the forecast is {_weatherForecast}. I look forward to seeing you there!\n{_address.GetAddressString()}");
    }
}