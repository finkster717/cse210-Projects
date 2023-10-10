public class Circle : Shape
{
    private double _radius;

    public Circle(string color, string type, double radius) : base(color, type)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}