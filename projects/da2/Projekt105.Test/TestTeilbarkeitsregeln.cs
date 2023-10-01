namespace Projekt105.Test;

public class TestTeilbarkeitsregeln
{
    [Theory]
    [InlineData(true, 0)]
    [InlineData(false, 1)]
    [InlineData(true, 2)]
    [InlineData(false, 3)]
    [InlineData(true, 4)]
    [InlineData(false, 5)]
    [InlineData(true, 6)]

    public void TestDurchZweiTeilbar(bool exp, uint zahl)
    {
        var teilbar = Teilbarkeitsregeln.DurchZweiTeilbar(zahl);

        Assert.Equal(exp, teilbar);
    }


    [Theory]
    [InlineData(true, 0)]
    [InlineData(false, 1)]
    [InlineData(false, 2)]
    [InlineData(true, 3)]
    [InlineData(false, 4)]
    [InlineData(false, 5)]
    [InlineData(true, 6)]
    [InlineData(false, 8)]
    [InlineData(true, 9)]

    public void TestDurchDreiTeilbar(bool exp, uint zahl)
    {
        var teilbar = Teilbarkeitsregeln.DurchDreiTeilbar(zahl);

        Assert.Equal(exp, teilbar);
    }

    [Theory]
    [InlineData(true, 0)]
    [InlineData(false, 1)]
    [InlineData(false, 2)]
    [InlineData(false, 3)]
    [InlineData(false, 4)]
    [InlineData(true, 5)]
    [InlineData(false, 6)]
    [InlineData(true, 10)]
    [InlineData(false, 12)]
    [InlineData(true, 15)]
    [InlineData(false, 16)]

    public void TestDurchFuenfTeilbar(bool exp, uint zahl)
    {
        var teilbar = Teilbarkeitsregeln.DurchFuenfTeilbar(zahl);

        Assert.Equal(exp, teilbar);
    }

    [Theory]
    [InlineData(true, 0)]
    [InlineData(false, 1)]
    [InlineData(false, 2)]
    [InlineData(false, 3)]
    [InlineData(false, 4)]
    [InlineData(false, 5)]
    [InlineData(true, 6)]
    [InlineData(false, 10)]
    [InlineData(true, 12)]
    [InlineData(false, 15)]
    [InlineData(true, 18)]

    public void TestDurchSechsTeilbar(bool exp, uint zahl)
    {
        var teilbar = Teilbarkeitsregeln.DurchSechsTeilbar(zahl);

        Assert.Equal(exp, teilbar);
    }
}
