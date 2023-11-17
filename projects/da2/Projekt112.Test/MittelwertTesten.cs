namespace Projekt112.Test;

public class MittelwertTesten
{
    public enum TestNr
    {
        Test0,
        Test1,
        Test2,
        Test3,
        Test4
    }

    private static readonly List<List<int>?> s_liste =
    [
        [1],
        [1, 2, 3],
        [1, 2, 3, 4, 5, 6, 7, 8, 9],
        [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12],
        [9, 8, 7, 6, 5, 4, 3, 2, 1]
    ];

    [Theory]
    [InlineData(1, TestNr.Test0)]
    [InlineData(2, TestNr.Test1)]
    [InlineData(5, TestNr.Test2)]
    [InlineData(6.5, TestNr.Test3)]
    [InlineData(5, TestNr.Test4)]

    public void TestMittelwert(double exp, TestNr testNr)
    {
        var mittelwert = Mittelwert.MittelwertBerechnen(s_liste[(int) testNr]);

        Assert.Equal(exp, mittelwert);
    }
}
