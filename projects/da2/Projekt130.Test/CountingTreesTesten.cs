namespace Projekt130.Test;

public class CountingTreesTesten
{
    [Theory]
    [InlineData(null, null)]
    [InlineData(null, "")]
    [InlineData(null, "a.1")]
    [InlineData(null, "0.1")]
    [InlineData(null, "0;1")]
    [InlineData(null, "0,1,2")]
    [InlineData(null, "3,6,2")]

    [InlineData("3", "1,1, 2,2, 3")]
    [InlineData("3", "3,1,1, 2,2 ")]
    [InlineData("8", "2, 2,2, 56,56, 56, 8,8")]
    [InlineData("64", "34, 76, 12, 99, 64, 99, 76, 12, 34")]

    [InlineData("3,3", "1,1,1, 2,2,2, 3")]
    [InlineData("3,3,5", "1,1,1, 2,2,2, 3,5,5")]
    [InlineData("3,3,5,7,7", "1,1,1, 2,2,2, 7, 3,5,5")]

    public void CountingTreesTest(string? exp, string? text)
    {
        var ergebnis = CountingTrees.CountTrees(text);

        Assert.Equal(exp, ergebnis);
    }
}
