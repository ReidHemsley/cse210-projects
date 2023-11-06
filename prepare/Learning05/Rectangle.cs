using System;

class Rectangle : Shape
{
    private double _len;
    private double _width;
    public Rectangle(string color, double length, double width) : base(color)
    {
        _len = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _len * _width;
    }
}