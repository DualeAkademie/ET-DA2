namespace Projekt115.Test;

public class TestZahlensystemNachBin
{
    [Theory]
    [InlineData("0b0000", null, ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("0b0000", "2#0", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0000", "0b0", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b0001", "2#1", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0010", "0b10", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("2#0001_0000", "2#0001_0000", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b1100_1000", "0b1100_1000", ZahlenKonvertieren.Zahlensystem.BinaerC)]

    public void TestBinaereZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }



    [Theory]
    [InlineData("0b0000", null, ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("0b0000", "16#0", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0000", "0x0", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b0001", "16#1", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0010", "0x2", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("2#0001_0000", "16#10", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b1100_1000", "0xC8", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0001_1110_0010_0100_0000", "16#1E240", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]

    public void TestHexadezimaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }


    [Theory]
    [InlineData("0b0000", null, ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("0b0000", "0", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0000", "0", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b0001", "1", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0010", "2", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b0111", "7", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0001_0000", "16", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b1100_1000", "200", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0001_1110_0010_0100_0000", "123456", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]

    public void TestDezimaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }


    [Theory]
    [InlineData("0b0000", "00", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0000", "8#0", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b0001", "01", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0010", "8#2", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b0111", "07", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0001_0000", "8#20", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]
    [InlineData("0b1100_1000", "0310", ZahlenKonvertieren.Zahlensystem.BinaerC)]
    [InlineData("2#0001_1110_0010_0100_0000", "8#361100", ZahlenKonvertieren.Zahlensystem.BinaerPlc)]

    public void TestOktaleZahlenKonvertieren(string exp, string zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }

}
