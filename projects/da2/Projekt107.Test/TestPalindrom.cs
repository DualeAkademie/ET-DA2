namespace Projekt107.Test;

public class TestPalindrom
{
    [Theory]
    [InlineData(false, null)]
    [InlineData(false, "")]
    [InlineData(true, "A")]
    [InlineData(true, "Kajak")]
    [InlineData(false, "apple")]
    [InlineData(true, "Regallager")]
    [InlineData(true, "Reittier")]
    [InlineData(true, "Rentner")]
    [InlineData(false, "Das ist kein Palindrom")]
    [InlineData(true, "Never odd or even")]
    [InlineData(true, "Was it a cat I saw")]
    [InlineData(true, "A man, a plan, a canal - Panama")]
    [InlineData(true, "Lag er im Kajak? Mir egal.")]


    public void PalindomTesten(bool exp, string? text)
    {
        var palindom = Palindrom.IstEinPalindrom(text);

        Assert.Equal(exp, palindom);
    }
}
