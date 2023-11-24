namespace Projekt122.Test;

public class LeibnizReiheTesten
{
    [Theory]
    [InlineData(0, -5)]
    [InlineData(0, 0)]

    [InlineData(4, 1)]
    [InlineData(2.66666666666, 2)]
    [InlineData(3.46666666666, 3)]
    [InlineData(2.89523809519, 4)]
    [InlineData(3.33968253970, 5)]
    [InlineData(2.97604617600, 6)]
    [InlineData(3.04183961890, 10)]
    [InlineData(3.09162380669, 20)]
    [InlineData(3.10826856670, 30)]
    [InlineData(3.12159465259, 50)]
    [InlineData(3.13159290360, 100)]
    [InlineData(3.13659268480, 200)]
    [InlineData(3.13825932949, 300)]
    [InlineData(3.13959265560, 500)]
    [InlineData(3.14059265380, 1000)]
    [InlineData(3.14109265359, 2000)]
    [InlineData(3.14125932030, 3000)]
    [InlineData(3.14139265360, 5000)]
    [InlineData(3.14149265359, 10000)]
    [InlineData(3.14154265360, 20000)]
    [InlineData(3.14155932029, 30000)]
    [InlineData(3.14157265359, 50000)]
    public void TestLeibnizReihe(double exp, int zahl)
    {
        var anzahl = LeibnizReihe.LeibnizReiheBerechnen(zahl);
        Assert.Equal(double.Round(exp, 10), double.Round(anzahl, 10));
    }
}
