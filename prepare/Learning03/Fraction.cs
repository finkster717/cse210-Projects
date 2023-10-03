using System.Dynamic;
using System.Xml.Serialization;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Initializing the fraction to 1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        // Initializing denominator to 1 and numerator to wholeNumber parameter
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        // Initializing fraction to set parameters
        _top = numerator;
        _bottom = denominator;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {

        return (double)_top/(double)_bottom;
    }
}