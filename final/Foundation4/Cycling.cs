public class Cycling : Activity
{
    private float _speed;

    public Cycling(string type, string date, int time, float speed) : base(type, date, time)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * (_time / 60);
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return _time / _speed;
    }
}