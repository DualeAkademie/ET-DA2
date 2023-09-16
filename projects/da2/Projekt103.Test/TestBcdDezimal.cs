
namespace Projekt103.Test;

public class TestBcdDezimal
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(0x11, 11)]
    [InlineData(0x42, 42)]
    [InlineData(0x1234, 1234)]
    [InlineData(0x5678, 5678)]


    public void TestDecimalToBcd(ushort exp, ushort dec)
    {
        var bcd = BcdDezimal.DecimalToBcd(dec);

        Assert.Equal(exp, bcd);
    }


    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(11, 0x11)]
    [InlineData(42, 0x42)]
    [InlineData(1234, 0x1234)]
    [InlineData(5678, 0x5678)]

    public void TestBcdToDecimal(ushort exp, ushort bcd)
    {
        var dec = BcdDezimal.BcdToDecimal(bcd);

        Assert.Equal(exp, dec);
    }
}
