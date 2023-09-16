namespace Projekt111.Test;

public class BitfunktionenTesten
{
    [Theory]
    [InlineData(false, 0b0000_0000_0000_0000, 0, Bitfunktionen.BitBefehl.BitGesetzt)]
    [InlineData(true, 0b0000_0000_0000_0000, 0, Bitfunktionen.BitBefehl.BitNichtGesetzt)]
    [InlineData(true, 0b0000_0000_0000_1000, 3, Bitfunktionen.BitBefehl.BitGesetzt)]
    [InlineData(false, 0b0000_0000_0000_1000, 3, Bitfunktionen.BitBefehl.BitNichtGesetzt)]
    [InlineData(true, 0b0000_0001_0000_1000, 8, Bitfunktionen.BitBefehl.BitGesetzt)]
    [InlineData(false, 0b0000_0001_0000_1000, 8, Bitfunktionen.BitBefehl.BitNichtGesetzt)]

    public void BitfunktionenTest(bool exp, uint wert, int position, Bitfunktionen.BitBefehl befehl)
    {
        var ergebnis = Bitfunktionen.BitTesten(wert, position, befehl);

        Assert.Equal(exp, ergebnis);
    }


    [Theory]
    [InlineData(0b0000_0000_0000_0001, 0b0000_0000_0000_0000, 0, Bitfunktionen.BitBefehl.BitSetzen)]
    [InlineData(0b0000_0000_0001_0001, 0b0000_0000_0000_0001, 4, Bitfunktionen.BitBefehl.BitSetzen)]

    [InlineData(0b1111_1111_1111_1110, 0b1111_1111_1111_1111, 0, Bitfunktionen.BitBefehl.BitLoeschen)]
    [InlineData(0b1111_1111_1110_1110, 0b1111_1111_1111_1110, 4, Bitfunktionen.BitBefehl.BitLoeschen)]


    public void BitManipulierenTest(uint exp, uint wert, int position, Bitfunktionen.BitBefehl befehl)
    {
        var ergebnis = Bitfunktionen.BitManipulieren(wert, position, befehl);

        Assert.Equal(exp, ergebnis);
    }
}
