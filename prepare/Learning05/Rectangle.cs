public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, string type, double length, double width) : base(color, type)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}