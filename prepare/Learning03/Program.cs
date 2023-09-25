using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(); // whitespace

        // demonstrating first constructor and associated methods
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"The first fraction is: {fraction1.GetFractionString()}");
        Console.WriteLine($"The first fraction's decimal value is: {fraction1.GetDecimalValue()}");

        // demonstrating second constructor and associated methods
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"The second fraction is: {fraction2.GetFractionString()}");
        Console.WriteLine($"The second fraction's decimal value is {fraction2.GetDecimalValue()}");

        // demonstrating third constructor and associated methods
        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine($"The third fraction is: {fraction3.GetFractionString()}");
        Console.WriteLine($"The third fraction's decimal value is: {fraction3.GetDecimalValue()}");

        // demonstrating one more for good measure
        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine($"The fourth fraction is: {fraction4.GetFractionString()}");
        Console.WriteLine($"The fourth fraction's decimal value is: {fraction4.GetDecimalValue()}");
    
        Console.WriteLine(); // whitespace
    }
}