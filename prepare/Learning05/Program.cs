using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        Square square1 = new Square("Blue", 5);
        _shapes.Add(square1);

        Rectangle rect1 = new Rectangle("Purple", 3, 7);
        _shapes.Add(rect1);

        Circle circ1 = new Circle("Red", 8);
        _shapes.Add(circ1);

        foreach (Shape i in _shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();

            Console.WriteLine($"{color} - {area}");
        }

    }
}