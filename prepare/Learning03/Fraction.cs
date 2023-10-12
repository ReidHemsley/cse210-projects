using System;

class Fraction
{

    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int Number)
    {
        _topNum = Number;
        _bottomNum = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNum = top;
        _bottomNum = bottom;
    }

    public string FracAsString()
    {
        string fracString = $"{_topNum}/{_bottomNum}";
        return fracString;
    }

    public double Decimal()
    {
        double doubleFrac = (double)_topNum / (double)_bottomNum;
        return doubleFrac;
    }

}