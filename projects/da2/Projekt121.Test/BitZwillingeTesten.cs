namespace Projekt121.Test;

public class BitZwillingeTesten
{
    [Theory]
    [InlineData(0, 0b0000_0000_0000_0000_0000_0000_0000_0000)]
    [InlineData(0, 0b0000_0000_0000_0000_0000_0000_0000_0001)]
    [InlineData(1, 0b0000_0000_0000_0000_0000_0000_0000_0011)]
    [InlineData(1, 0b0000_0000_0000_0000_0000_0000_0000_0110)]
    [InlineData(2, 0b0000_0000_0000_0000_0000_0000_0000_0111)]
    [InlineData(4, 0b0111_0000_0000_0000_0000_0000_0000_0111)]
    [InlineData(1, 0b1100_0000_0000_0000_0000_0000_0000_0000)]
    [InlineData(0, 0b1000_0000_0000_0000_0000_0000_0000_0000)]

    public void TestZiffernZaehlen(int exp, UInt32 zahl)
    {
        var anzahl = Bitzwillinge.BitZwillingeZaehlen(zahl);
        Assert.Equal(exp, anzahl);
    }
}
