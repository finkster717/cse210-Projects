public class Swimming : Activity
{
    private int _laps;

    public Swimming(string type, string date, int time, int laps) : base(type, date, time)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return (float)(_laps * 50 / 1000 * 0.62);
    }

    public override float GetSpeed()
    {
        return GetDistance() / _time * 60;
    }

    public override float GetPace()
    {
        return _time / GetDistance();
    }
}