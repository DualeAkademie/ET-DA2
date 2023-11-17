namespace Projekt115.Test;

public class TestZahlensystemNachOct
{
    [Theory]
    [InlineData("00", null, ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("00", "2#0", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#0", "0b0", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("01", "2#1", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#2", "0b10", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("020", "2#0001_0000", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#310", "0b1100_1000", ZahlenKonvertieren.Zahlensystem.OktalPlc)]

    public void TestBinaereZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }



    [Theory]
    [InlineData("00", null, ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("00", "16#0", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#0", "0x0", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("01", "16#1", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#2", "0x2", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("010", "16#8", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#310", "0xC8", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("0361100", "16#1E240", ZahlenKonvertieren.Zahlensystem.OktalC)]

    public void TestHexadezimaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }


    [Theory]
    [InlineData("00", null, ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("00", "0", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#0", "0", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("01", "1", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#2", "2", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("07", "7", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#20", "16", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("0310", "200", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#361100", "123456", ZahlenKonvertieren.Zahlensystem.OktalPlc)]

    public void TestDezimaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }


    [Theory]
    [InlineData("00", null, ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("00", "00", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#0", "8#0", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("01", "01", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#2", "8#2", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("07", "07", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#20", "8#20", ZahlenKonvertieren.Zahlensystem.OktalPlc)]
    [InlineData("0310", "0310", ZahlenKonvertieren.Zahlensystem.OktalC)]
    [InlineData("8#361100", "8#361100", ZahlenKonvertieren.Zahlensystem.OktalPlc)]

    public void TestOktaleZahlenKonvertieren(string exp, string zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }

}
