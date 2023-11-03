namespace Projekt510.Test;

public class DezToBinHexTesten
{
    [Theory]
    [InlineData("2#0000__0000", 0, 0, Model.Umrechnungen.Zahlensystem.BinaerPlc)]
    [InlineData("0b0000__0000", 0, 1, Model.Umrechnungen.Zahlensystem.BinaerC)]
    [InlineData("2#0000__0001", 1, 1, Model.Umrechnungen.Zahlensystem.BinaerPlc)]
    [InlineData("0b0000__1001", 9, 1, Model.Umrechnungen.Zahlensystem.BinaerC)]
    [InlineData("2#0001__0000", 16, 1, Model.Umrechnungen.Zahlensystem.BinaerPlc)]
    [InlineData("0b1111__1110", 254, 1, Model.Umrechnungen.Zahlensystem.BinaerC)]
    [InlineData("2#0011__0000__0011__1001", 12345, 2, Model.Umrechnungen.Zahlensystem.BinaerPlc)]

    public void DezimalToBinTesten(string exp, int dezimal, int anzahlByte, Model.Umrechnungen.Zahlensystem zahlensystem)
    {
        var (bin, _) = Model.Umrechnungen.DezimalToBinaer(dezimal, anzahlByte, zahlensystem);

        Assert.Equal(exp, bin);
    }


    [Theory]
    [InlineData("16#00", 0, 0, Model.Umrechnungen.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x00", 0, 1, Model.Umrechnungen.Zahlensystem.HexadezimalC)]
    [InlineData("16#01", 1, 1, Model.Umrechnungen.Zahlensystem.HexadezimalPlc)]
    [InlineData("0x09", 9, 1, Model.Umrechnungen.Zahlensystem.HexadezimalC)]
    [InlineData("16#10", 16, 1, Model.Umrechnungen.Zahlensystem.HexadezimalPlc)]
    [InlineData("0xFE", 254, 1, Model.Umrechnungen.Zahlensystem.HexadezimalC)]
    [InlineData("16#3039", 12345, 2, Model.Umrechnungen.Zahlensystem.HexadezimalPlc)]

    public void DezimalToHexTesten(string exp, int dezimal, int anzahlByte, Model.Umrechnungen.Zahlensystem zahlensystem)
    {
        var (bin, _) = Model.Umrechnungen.DezimalToHexadezimal(dezimal, anzahlByte, zahlensystem);

        Assert.Equal(exp, bin);
    }

}
