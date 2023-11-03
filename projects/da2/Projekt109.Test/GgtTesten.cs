namespace Projekt109.Test;

public class GgtTesten
{
    [Theory]
    [InlineData(0, 0, 0)]

    [InlineData(1, 1, 0)]
    [InlineData(1, 0, 1)]

    [InlineData(1, 2, 3)]
    [InlineData(1, 5, 12)]

    [InlineData(2, 52, 22)]
    [InlineData(5, 5, 15)]

    public void GgtTest(int exp, int a, int b)
    {
        var ergebnis = Zahlen.GgtBerechnen(a, b);

        Assert.Equal(exp, ergebnis);
    }
}
