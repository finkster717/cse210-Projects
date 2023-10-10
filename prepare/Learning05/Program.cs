using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("green", "square", 3);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("blue", "rectangle", 1, 6);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("red", "circle", 2);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            string type = shape.GetShapeType();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} {type} has an area of {area}");
        }

        Console.WriteLine();
    }
}