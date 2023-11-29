namespace Projekt115.Test;

public class TestZahlensystemNachHex
{
    [Theory]
    [InlineData("0x0", null, ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("0x0", "2#0", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#0", "0b0", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x1", "2#1", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#2", "0b10", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x10", "2#0001_0000", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#C8", "0b1100_1000", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]

    public void TestBinaereZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }



    [Theory]
    [InlineData("0x0", null, ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("0x0", "16#0", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#0", "0x0", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x1", "16#1", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#2", "0x2", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x8", "16#8", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#C8", "0xC8", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x1E240", "16#1E240", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]

    public void TestHexadezimaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }


    [Theory]
    [InlineData("0x0", null, ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("0x0", "0", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#0", "0", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x1", "1", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#2", "2", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x7", "7", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#10", "16", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0xC8", "200", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#1E240", "123456", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]

    public void TestDezimaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }


    [Theory]
    [InlineData("0x0", null, ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("0x0", "00", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#0", "8#0", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x1", "01", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#2", "8#2", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x7", "07", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#10", "8#20", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]
    [InlineData("0xC8", "0310", ZahlenKonvertieren.Zahlensystem.HexadezimalC)]
    [InlineData("16#1E240", "8#361100", ZahlenKonvertieren.Zahlensystem.HexadezimalPlc)]

    public void TestOktaleZahlenKonvertieren(string exp, string? zahl, ZahlenKonvertieren.Zahlensystem zahlensystem)
    {
        var zahlBin = ZahlenKonvertieren.ZahlensystemKonvertieren(zahl, zahlensystem);

        Assert.Equal(exp, zahlBin);
    }

}
