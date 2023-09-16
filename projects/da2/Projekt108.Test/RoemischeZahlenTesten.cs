namespace Projekt108.Test;

public class RoemischeZahlenTesten
{

    [Theory]
    [InlineData(0, "")]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    [InlineData(9, "IX")]
    [InlineData(10, "X")]
    [InlineData(11, "XI")]
    [InlineData(13, "XIII")]
    [InlineData(14, "XIV")]
    [InlineData(15, "XV")]
    [InlineData(16, "XVI")]
    [InlineData(18, "XVIII")]
    [InlineData(19, "XIX")]
    [InlineData(44, "XLIV")]
    [InlineData(409, "CDIX")]
    [InlineData(900, "CM")]
    [InlineData(1000, "M")]
    [InlineData(2999, "MMCMXCIX")]
    [InlineData(3000, "MMM")]

    public void TestDezimalInRoemischUmrechnen(uint dezimal, string roemisch)
    {
        var ergebnis = RoemischeZahlen.DezimalInRoemischUmrechnen(dezimal);
        Assert.Equal(roemisch, ergebnis);
    }

    [Theory]
    [InlineData(0, null)]
    [InlineData(0, "")]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    [InlineData(9, "IX")]
    [InlineData(10, "X")]
    [InlineData(11, "XI")]
    [InlineData(13, "XIII")]
    [InlineData(14, "XIV")]
    [InlineData(15, "XV")]
    [InlineData(16, "XVI")]
    [InlineData(18, "XVIII")]
    [InlineData(19, "XIX")]
    [InlineData(44, "XLIV")]
    [InlineData(409, "CDIX")]
    [InlineData(900, "CM")]
    [InlineData(1000, "M")]
    [InlineData(2999, "MMCMXCIX")]
    [InlineData(3000, "MMM")]
    public void TestKonstruktorSetRoemisch(uint dezimal, string roemisch)
    {
        var ergebnis = RoemischeZahlen.RoemischInDezimalUmrechnen(roemisch);
        Assert.Equal(dezimal, ergebnis);
    }
}
