namespace Projekt115.Test;

public class TestZahlensystemNachDec
{
    [Theory]
    [InlineData("0", null, ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("0", "2#0", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("0", "0b0", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("1", "2#1", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("2", "0b10", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("16", "2#0001_0000", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("200", "0b1100_1000", ZahlenKonvertieren.Zahlensystem.Dezimal)]

    public void TestBinaereZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }



    [Theory]
    [InlineData("0", null, ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("0", "16#0", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("0", "0x0", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("1", "16#1", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("2", "0x2", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("8", "16#8", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("200", "0xC8", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("123456", "16#1E240", ZahlenKonvertieren.Zahlensystem.Dezimal)]

    public void TestHexadezimaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }


    [Theory]
    [InlineData("0", null, ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("0", "0", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("1", "1", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("2", "2", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("7", "7", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("16", "16", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("200", "200", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("123456", "123456", ZahlenKonvertieren.Zahlensystem.Dezimal)]

    public void TestDezimaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }


    [Theory]
    [InlineData("0", null, ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("0", "00", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("0", "8#0", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("1", "01", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("2", "8#2", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("7", "07", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("16", "8#20", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("200", "0310", ZahlenKonvertieren.Zahlensystem.Dezimal)]
    [InlineData("123456", "8#361100", ZahlenKonvertieren.Zahlensystem.Dezimal)]

    public void TestOktaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }

}
