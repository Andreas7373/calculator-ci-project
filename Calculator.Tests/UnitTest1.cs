using Xunit;
using Calculator;

namespace Calculator.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var result = _calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectResult()
    {
        var result = _calculator.Subtract(5, 3);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Multiply_ShouldReturnCorrectResult()
    {
        var result = _calculator.Multiply(4, 3);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Divide_ShouldReturnCorrectResult()
    {
        var result = _calculator.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }

    [Fact]
    public void Add_WithNegativeNumbers()
    {
        var result = _calculator.Add(-2, -3);
        Assert.Equal(-5, result);
    }

    [Fact]
    public void Multiply_WithZero()
    {
        var result = _calculator.Multiply(5, 0);
        Assert.Equal(0, result);
    }
}