namespace Neolution.ReleaseProcessTest.Calculator;

/// <summary>
/// Basic calculator class with some arithmetic operations
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <param name="result">Output parameter for the sum of a and b</param>
    public void Add(double a, double b, out double result)
    {
        result = a + b;
    }

    /// <summary>
    /// Subtracts two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Difference of a and b</returns>
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Product of a and b</returns>
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// Divides two numbers
    /// </summary>
    /// <param name="a">Dividend</param>
    /// <param name="b">Divisor</param>
    /// <returns>Quotient of a and b</returns>
    public double Divide(double a, double b)
    {
        return a / b;
    }

    /// <summary>
    /// Raises a number to a power
    /// </summary>
    /// <param name="base">Base number</param>
    /// <param name="exponent">Exponent</param>
    /// <returns>Base raised to the power of exponent</returns>
    public double Power(double @base, double exponent)
    {
        return Math.Pow(@base, exponent);
    }
}