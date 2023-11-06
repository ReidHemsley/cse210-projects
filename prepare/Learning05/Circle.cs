using System;

class Circle : Shape
{
    private double _rad;
    public Circle(string color, double radius) : base(color)
    {
        _rad = radius;
    }

    public override double GetArea()
    {
        return _rad * _rad * Math.PI;
    }
}