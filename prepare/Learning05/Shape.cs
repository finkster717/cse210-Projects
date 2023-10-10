public abstract class Shape
{
    protected string _color;
    protected string _type;

    public Shape(string color, string type)
    {
        _color = color;
        _type = type;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetShapeType()
    {
        return _type;
    }

    public void SetType(string type)
    {
        _type = type;
    }

    public abstract double GetArea();
}