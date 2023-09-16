namespace Projekt102.Test;
public class ByteDividieren
{
    [Theory]
    [InlineData(0, 0, 1)]
    [InlineData(1, 1, 1)]
    [InlineData(2, 5, 2)]
    [InlineData(1, 7, 5)]

    public void ByteDividierenTesten(byte exp, byte dividend, byte divisor)
    {
        var quotient = GrundrechenartenByte.Dividieren(dividend, divisor);

        Assert.Equal(exp, quotient);
    }


    [Theory]
    [InlineData(0, 0, 1)]
    [InlineData(0, 1, 1)]
    [InlineData(1, 5, 2)]
    [InlineData(2, 7, 5)]

    public void ByteDivisionRestBerechnenTesten(byte exp, byte dividend, byte divisor)
    {
        var rest = GrundrechenartenByte.RestBerechnen(dividend, divisor);

        Assert.Equal(exp, rest);
    }
}
