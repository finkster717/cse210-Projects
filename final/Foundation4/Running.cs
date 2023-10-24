public class Running : Activity
{
    private float _distance;

    public Running(string type, string date, int time, float distance) : base(type, date, time)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
    
    public override float GetSpeed()
    {
        return _distance / _time * 60;
    }
    
    public override float GetPace()
    {
        return _time / _distance;
    }
}