namespace Projekt116.Test;

public class ZiffernquersummeTesten
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(9, 9)]
    [InlineData(1, 10)]
    [InlineData(1, 100)]
    [InlineData(2, 11)]
    [InlineData(3, 111)]
    [InlineData(45, 123456789)]

    public void TestZiffernquersumme(uint exp, uint zahl)
    {
        var ziffernquersumme = Ziffernquersumme.ZiffernquersummeBerechnen(zahl);

        Assert.Equal(exp, ziffernquersumme);
    }
}
