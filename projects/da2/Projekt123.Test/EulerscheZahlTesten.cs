namespace Projekt123.Test;

public class EulerscheZahlTesten
{
    [Theory]
    [InlineData(0, -5)]
    [InlineData(0, 0)]
    [InlineData(2, 1)]
    [InlineData(2.5, 2)]
    [InlineData(2.66666666666, 3)]
    [InlineData(2.70833333333, 4)]
    [InlineData(2.71666666666, 5)]
    [InlineData(2.71805555555, 6)]
    [InlineData(2.7182539683, 7)]
    [InlineData(2.7182787698, 8)]
    [InlineData(2.7182815256, 9)]
    [InlineData(2.7182818011, 10)]
    [InlineData(2.7182818285, 20)]
    [InlineData(2.7182818285, 30)]
    [InlineData(2.7182818285, 50)]
    [InlineData(2.7182818285, 60)]

    public void TestEulerscheZahl(double exp, long zahl)
    {
        var anzahl = EulerscheZahl.EulerscheZahlBerechnen(zahl);
        Assert.Equal(double.Round(exp, 10), double.Round(anzahl, 10));
    }
}
