namespace Projekt120.Test;

public class BuchstabenLesenTesten
{
    [Theory]
    [InlineData(false, ' ', "abcdefghijklmnopqrst", -1)]
    [InlineData(false, ' ', "", 0)]
    [InlineData(false, ' ', "ab", 2)]
    [InlineData(false, ' ', "abcdefghijklmnopqrst", 1000)]

    [InlineData(true, 'a', "abcdefghijklmnopqrst", 0)]
    [InlineData(true, 'b', "abcdefghijklmnopqrst", 1)]

    public void BuchstabenLesenTest(bool expErgebnis, char expZeichen, string text, int position)
    {
        var ergebnis = BuchstabenFunktionen.EinBuchstabeLesen(text, position, out var zeichen);

        Assert.Equal(expErgebnis, ergebnis);
        Assert.Equal(expZeichen, zeichen);
    }
}
