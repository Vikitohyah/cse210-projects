using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction f1: {f1.GetFractionString()}");

        Fraction f2 = new Fraction();
        Console.WriteLine($"Fraction f2: {f2.GetNumerator()}");

        Fraction f3 = new Fraction(5, 1);
        Console.WriteLine($"Fraction f3: {f3.GetFractionString()}");

        Fraction f4 = new Fraction();
        f4.SetNumerator(5);
        Console.WriteLine($"Fraction f4: {f4.GetNumerator()}");

        Fraction f5 = new Fraction(3, 4);
        Console.WriteLine($"Fraction f5: {f5.GetFractionString()}");

        Fraction f6 = new Fraction(3, 4);
        Console.WriteLine($"Fraction f6: {f6.GetDecimalValue()}");

        Fraction f7 = new Fraction(1, 3);
        Console.WriteLine($"Fraction f7: {f7.GetFractionString()}");

        Fraction f8 = new Fraction(1, 3);
        Console.WriteLine($"Fraction f8: {f8.GetDecimalValue()}");

    }
}