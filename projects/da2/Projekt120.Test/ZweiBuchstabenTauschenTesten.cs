namespace Projekt120.Test;
public class ZweiBuchstabenTauschenTesten
{
    [Theory]

    [InlineData(false, " ", " ", -1, 0)]
    [InlineData(false, " ", " ", 0, -1)]
    [InlineData(false, "", "", 0, 0)]
    [InlineData(false, " ", " ", 1, 0)]
    [InlineData(false, " ", " ", 0, 1)]

    [InlineData(true,"bacdefghijklmnopqrst", "abcdefghijklmnopqrst", 0, 1)]
    [InlineData(true, "abfdecghijklmnopqrst", "abcdefghijklmnopqrst", 5, 2)]


    public void ZweiBuchstabenTauschenTeste(bool expBool, string expText, string? text, int position1, int position2)
    {
        var exp = BuchstabenFunktionen.ZweiBuchstabenTauschen(ref text, position1, position2);

        Assert.Equal(exp, expBool);
        Assert.Equal(expText, text);
    }
}
