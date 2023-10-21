namespace Projekt510.Test;

public class DezToBinHexTesten
{
    [Theory]
    [InlineData("2#0000__0000", 0, 0)]
    [InlineData("2#0000__0000", 0, 1)]
    [InlineData("2#0000__0001", 1, 1)]
    [InlineData("2#0000__1001", 9, 1)]
    [InlineData("2#0001__0000", 16, 1)]
    [InlineData("2#1111__1110", 254, 1)]
    [InlineData("2#0011__0000__0011__1001", 12345, 2)]

    public void DezimalToBinTesten(string exp, int dezimal, int anzahlByte)
    {
        var (bin, _) = Model.Umrechnungen.DezimalToBinaer(dezimal, anzahlByte);

        Assert.Equal(exp, bin);
    }


    [Theory]
    [InlineData("16#00", 0, 0, Model.Umrechnungen.HexadezimalStil.Plc)]
    [InlineData("0x00", 0, 1, Model.Umrechnungen.HexadezimalStil.C)]
    [InlineData("16#01", 1, 1, Model.Umrechnungen.HexadezimalStil.Plc)]
    [InlineData("0x09", 9, 1, Model.Umrechnungen.HexadezimalStil.C)]
    [InlineData("16#10", 16, 1, Model.Umrechnungen.HexadezimalStil.Plc)]
    [InlineData("0xFE", 254, 1, Model.Umrechnungen.HexadezimalStil.C)]
    [InlineData("16#3039", 12345, 2, Model.Umrechnungen.HexadezimalStil.Plc)]

    public void DezimalToHexTesten(string exp, int dezimal, int anzahlByte, Model.Umrechnungen.HexadezimalStil stil)
    {
        var (bin, _) = Model.Umrechnungen.DezimalToHexadezimal(dezimal, anzahlByte, stil);

        Assert.Equal(exp, bin);
    }

}
