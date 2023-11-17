namespace Projekt118.Test;

public class ZiffernZaehlenTesten
{
    [Theory]
    [InlineData(1, 0, 0)]
    [InlineData(0, 123456789, 0)]
    [InlineData(2, 1122334578, 1)]
    [InlineData(2, 1122334578, 2)]

    public void TestZiffernZaehlen(int exp, uint zahl, uint ziffer)
    {
        var anzahl = ZiffernZaehlen.Zaehlen(zahl, ziffer);

        Assert.Equal(exp, anzahl);
    }
}
