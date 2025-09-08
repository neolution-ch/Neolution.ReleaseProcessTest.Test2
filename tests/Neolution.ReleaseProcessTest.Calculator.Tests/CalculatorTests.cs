using Shouldly;
using Xunit;

namespace Neolution.ReleaseProcessTest.Calculator.Tests;

/// <summary>
/// Unit tests for the Calculator class
/// </summary>
public class CalculatorTests
{
    private readonly Calculator _calculator;

    /// <summary>
    /// Initializes a new instance of the CalculatorTests class.
    /// Sets up the Calculator instance for testing.
    /// </summary>
    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    /// <summary>
    /// Tests that the Add method returns the correct sum for various inputs.
    /// </summary>
    /// <param name="a">First number to add.</param>
    /// <param name="b">Second number to add.</param>
    /// <param name="expected">Expected sum result.</param>
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(10.5, 2.5, 13)]
    public void Add_ShouldReturnCorrectSum(double a, double b, double expected)
    {
        // Act
        var result = _calculator.Add(a, b);

        // Assert
        result.ShouldBe(expected);
    }

    /// <summary>
    /// Tests that the Subtract method returns the correct difference for various inputs.
    /// </summary>
    /// <param name="a">Minuend.</param>
    /// <param name="b">Subtrahend.</param>
    /// <param name="expected">Expected difference result.</param>
    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(-1, 1, -2)]
    [InlineData(0, 0, 0)]
    [InlineData(10.5, 2.5, 8)]
    public void Subtract_ShouldReturnCorrectDifference(double a, double b, double expected)
    {
        // Act
        var result = _calculator.Subtract(a, b);

        // Assert
        result.ShouldBe(expected);
    }

    /// <summary>
    /// Tests that the Multiply method returns the correct product for various inputs.
    /// </summary>
    /// <param name="a">First factor.</param>
    /// <param name="b">Second factor.</param>
    /// <param name="expected">Expected product result.</param>
    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-1, 1, -1)]
    [InlineData(0, 5, 0)]
    [InlineData(10.5, 2, 21)]
    public void Multiply_ShouldReturnCorrectProduct(double a, double b, double expected)
    {
        // Act
        var result = _calculator.Multiply(a, b);

        // Assert
        result.ShouldBe(expected);
    }
}