public class Square : Shape
{
    private double _side;

    public Square(string color, string type, double side) : base(color, type)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}