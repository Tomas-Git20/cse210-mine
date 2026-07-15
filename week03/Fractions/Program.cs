using System;

class Program
{
    static void Main(string[] args)
    {
        // Test all three constructors

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine("Testing Constructors:");
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        Console.WriteLine();

        // Test getters
        Console.WriteLine("Testing Getters:");
        Console.WriteLine($"Top: {fraction3.GetTop()}");
        Console.WriteLine($"Bottom: {fraction3.GetBottom()}");

        Console.WriteLine();

        // Test setters
        fraction3.SetTop(3);
        fraction3.SetBottom(4);

        Console.WriteLine("After using Setters:");
        Console.WriteLine($"Top: {fraction3.GetTop()}");
        Console.WriteLine($"Bottom: {fraction3.GetBottom()}");

        Console.WriteLine();

        // Test string and decimal representations
        Console.WriteLine("Representations:");
        Console.WriteLine($"Fraction: {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal: {fraction3.GetDecimalValue()}");

        Console.WriteLine();

        // Additional examples
        Fraction fraction4 = new Fraction(5, 8);
        Fraction fraction5 = new Fraction(9, 2);

        Console.WriteLine($"{fraction4.GetFractionString()} = {fraction4.GetDecimalValue()}");
        Console.WriteLine($"{fraction5.GetFractionString()} = {fraction5.GetDecimalValue()}");
    }
}