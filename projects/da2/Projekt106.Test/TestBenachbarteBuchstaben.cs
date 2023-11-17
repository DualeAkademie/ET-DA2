namespace Projekt106.Test;

public class TestBenachbarteBuchstaben
{
    [Theory]
    [InlineData(false, null)]
    [InlineData(false, "")]
    [InlineData(false, "123")]
    [InlineData(false, "a")]
    [InlineData(false, "aAbBcC")]
    [InlineData(true, "abCd")]
    [InlineData(true, "134ABCd")]


    public void BenachbarteBuchstabenTesten(bool exp, string? text)
    {
        var benachbart = BenachbarteBuchstaben.TextHatBenachbarteBuchstaben(text);

        Assert.Equal(exp, benachbart);
    }
}
