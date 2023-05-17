using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        f1.SetTop(2);
        f2.SetTop(3);
        f3.SetTop(4);

        f1.SetBottom(5);
        f2.SetBottom(6);
        f3.SetBottom(7);

        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f2.GetTop());
        Console.WriteLine(f3.GetTop());

        Console.WriteLine(f1.GetBottom());
        Console.WriteLine(f2.GetBottom());
        Console.WriteLine(f3.GetBottom());

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());

        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetDecimalValue());
    }
}