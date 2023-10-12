using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction(1);
        Console.WriteLine(frac1.FracAsString());
        Console.WriteLine(frac1.Decimal());
        
        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.FracAsString());
        Console.WriteLine(frac2.Decimal());

        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.FracAsString());
        Console.WriteLine(frac3.Decimal());

        Fraction frac4 = new Fraction(1, 3);
        Console.WriteLine(frac4.FracAsString());
        Console.WriteLine(frac4.Decimal());
    }
}