namespace Projekt113.Test;
public class FakultaetTesten
{
    [Theory]
    [InlineData(1, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(6, 3)]
    [InlineData(24, 4)]
    [InlineData(120, 5)]
    [InlineData(720, 6)]
    [InlineData(5040, 7)]
    [InlineData(40320, 8)]
    [InlineData(362880, 9)]
    [InlineData(3628800, 10)]
    [InlineData(39916800, 11)]
    [InlineData(2432902008176640000, 20)]

    public void TestFakultaet(ulong exp, ushort dec)
    {
        var fakultaet = Fakultaet.FakultaetBerechnen(dec);

        Assert.Equal(exp, fakultaet);
    }
}
