namespace Projekt112.Test;

public class MedianTesten
{
    public enum TestNr
    {
        Test0,
        Test1,
        Test2,
        Test3,
        Test4,
        Test5,
        Test6
    }

    private static readonly List<List<int>?> s_liste = new()
    {
        new List<int> {1},
        new List<int> {1,2,3},
        new List<int> {2,1,3},
        new List<int> {1,2,3,4,5,6,7,8,9},
        new List<int> {9,8,7,6,5,4,3,2,1},
        new List<int> {1,2,3,4,5,6},
        new List<int> {6,5,4,3,2,1}
    };

    [Theory]
    [InlineData(1, TestNr.Test0)]
    [InlineData(2, TestNr.Test1)]
    [InlineData(2, TestNr.Test2)]
    [InlineData(5, TestNr.Test3)]
    [InlineData(5, TestNr.Test4)]
    [InlineData(3.5, TestNr.Test5)]
    [InlineData(3.5, TestNr.Test6)]

    public void TestMittelwert(double exp, TestNr testNr)
    {
        var mittelwert = Median.MedianBerechnen(s_liste[(int) testNr]);

        Assert.Equal(exp, mittelwert);
    }
}
