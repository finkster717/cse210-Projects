public abstract class Activity
{
    protected string _activityType;
    protected string _date;
    protected int _time;

    public Activity(string type, string date, int time)
    {
        _activityType = type;
        _date = date;
        _time = time;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    
    public string GetSummary()
    {
        return $"{_date} | {_activityType} ({_time} min): Distance {GetDistance():.0} mile(s), Speed: {GetSpeed():.0} mph, Pace: {GetPace():.0} min per mile";
    }
}