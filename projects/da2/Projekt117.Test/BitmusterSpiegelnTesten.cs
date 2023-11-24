namespace Projekt117.Test;

public class BitmusterSpiegelnTesten
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(0b1000_0000_0000_0000_0000_0000_0000_0000, 0b0000_0000_0000_0000_0000_0000_0000_0001)]
    [InlineData(0b1100_0000_0000_0000_0000_0000_0000_0000, 0b0000_0000_0000_0000_0000_0000_0000_0011)]
    [InlineData(0b1010_0000_0000_0000_0000_0000_0000_0000, 0b0000_0000_0000_0000_0000_0000_0000_0101)]
    [InlineData(0b1001_0000_0000_0000_0000_0000_0000_0000, 0b0000_0000_0000_0000_0000_0000_0000_1001)]
    [InlineData(0b1000_0000_0000_0000_0000_0000_0000_0001, 0b1000_0000_0000_0000_0000_0000_0000_0001)]
    [InlineData(0b0000_1111_0000_0000_0000_0000_0000_0000, 0b0000_0000_0000_0000_0000_0000_1111_0000)]
    [InlineData(0b0000_0000_1001_0000_0000_0000_0000_0000, 0b0000_0000_0000_0000_0000_1001_0000_0000)]

    public void TestBitmusterSpiegeln(uint exp, uint bitmuster)
    {
        var bitmusterSpielgen = BitmusterSpiegeln.BitmusterSpielgen(bitmuster);

        Assert.Equal(exp, bitmusterSpielgen);
    }
}