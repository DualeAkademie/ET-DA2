namespace Projekt109.Test;
public class KgvTesten
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 0, 1)]
    [InlineData(0, 1, 0)]

    [InlineData(1, 1, 1)]

    [InlineData(4, 2, 4)]

    [InlineData(5, 1, 5)]
    [InlineData(5, 5, 1)]

    [InlineData(6, 2, 3)]
    [InlineData(12, 4, 12)]
    [InlineData(75, 15, 25)]
    [InlineData(180, 15, 36)]

    public void KgvTest(int exp, int a, int b)
    {
        var ergebnis = Zahlen.KgvBerechnen(a, b);

        Assert.Equal(exp, ergebnis);
    }
}
