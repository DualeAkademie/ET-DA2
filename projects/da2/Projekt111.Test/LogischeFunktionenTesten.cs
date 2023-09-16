namespace Projekt111.Test;
public class LogischeFunktionenTesten
{
    [Theory]
    [InlineData(0b0000_0000, 0b0000_0000, 0b0000_0000, LogischeFunktionen.LogischeOperationen.Und)]
    [InlineData(0b0000_0110, 0b0000_1111, 0b0000_0110, LogischeFunktionen.LogischeOperationen.Und)]
    [InlineData(0b0001_0000, 0b1111_1111, 0b0001_0000, LogischeFunktionen.LogischeOperationen.Und)]

    [InlineData(0b0000_0000, 0b0000_0000, 0b0000_0000, LogischeFunktionen.LogischeOperationen.Oder)]
    [InlineData(0b0000_1111, 0b0000_1111, 0b0000_0110, LogischeFunktionen.LogischeOperationen.Oder)]
    [InlineData(0b1111_1111, 0b1111_1111, 0b0001_0000, LogischeFunktionen.LogischeOperationen.Oder)]

    [InlineData(0b0000_0000, 0b0000_0000, 0b0000_0000, LogischeFunktionen.LogischeOperationen.ExklusivOder)]
    [InlineData(0b0000_1001, 0b0000_1111, 0b0000_0110, LogischeFunktionen.LogischeOperationen.ExklusivOder)]
    [InlineData(0b1110_1111, 0b1111_1111, 0b0001_0000, LogischeFunktionen.LogischeOperationen.ExklusivOder)]

    [InlineData(0b1111_1111_1111_1111_1111_1111_1111_1111, 0b0000_0000, 0b0000_0000, LogischeFunktionen.LogischeOperationen.Nicht)]
    [InlineData(0b1111_1111_1111_1111_1111_1111_1111_0000, 0b0000_1111, 0b0000_0110, LogischeFunktionen.LogischeOperationen.Nicht)]
    [InlineData(0b1111_1111_1111_1111_1111_1111_0000_0000, 0b1111_1111, 0b0001_0000, LogischeFunktionen.LogischeOperationen.Nicht)]


    public void BitfunktionenTest(uint exp, uint a, uint b, LogischeFunktionen.LogischeOperationen operationen)
    {
        var ergebnis = LogischeFunktionen.Funktionen(a, b, operationen);

        Assert.Equal(exp, ergebnis);
    }
}
