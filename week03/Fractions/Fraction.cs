using System;

public class Fraction
{
    // Private attributes
    private int top;
    private int bottom;

    // Constructor with no parameters (1/1)
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    // Constructor with one parameter (top/1)
    public Fraction(int top)
    {
        this.top = top;
        bottom = 1;
    }

    // Constructor with two parameters (top/bottom)
    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    // Getter and Setter for top
    public int GetTop()
    {
        return top;
    }

    public void SetTop(int top)
    {
        this.top = top;
    }

    // Getter and Setter for bottom
    public int GetBottom()
    {
        return bottom;
    }

    public void SetBottom(int bottom)
    {
        this.bottom = bottom;
    }

    // Returns the fraction as a string
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }

    // Returns the decimal value
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}