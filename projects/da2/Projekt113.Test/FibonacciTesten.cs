namespace Projekt113.Test;

public class FibonacciTesten
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(1, 2)]
    [InlineData(2, 3)]
    [InlineData(3, 4)]
    [InlineData(5, 5)]
    [InlineData(8, 6)]
    [InlineData(13, 7)]
    [InlineData(21, 8)]
    [InlineData(34, 9)]
    [InlineData(55, 10)]
    [InlineData(75025, 25)]
    [InlineData(12586269025, 50)]

    public void TestFibonacciFolge(ulong exp, ushort dec)
    {
        var fibonacciFolge = Fibonacci.FibonacciFolgeBerechnen(dec);

        Assert.Equal(exp, fibonacciFolge);
    }
}
