namespace Projekt109.Test;
public class PrimzahlenTesten
{
    public enum TestNr
    {
        Test0,
        Test1,
        Test2,
        Test3,
        Test4,
        Test5,
        Test6,
        Test10 = 7,
        Test12 = 8,
        Test123 = 9,
        Test12345 = 10

    }
    private readonly List<List<int>> _primzahlen =
  [
      [],
      [],
      [2],
      [3],
      [2, 2],
      [5],
      [2, 3],
      [2, 5],
      [2, 2, 3],
      [3, 41],
      [3, 5, 823]
  ];


    [Theory]
    [InlineData(0, TestNr.Test0)]
    [InlineData(1, TestNr.Test1)]
    [InlineData(2, TestNr.Test2)]
    [InlineData(3, TestNr.Test3)]
    [InlineData(4, TestNr.Test4)]
    [InlineData(5, TestNr.Test5)]
    [InlineData(6, TestNr.Test6)]
    [InlineData(10, TestNr.Test10)]
    [InlineData(12, TestNr.Test12)]
    [InlineData(123, TestNr.Test123)]
    [InlineData(12345, TestNr.Test12345)]

    public void BenachbarteBuchstabenTesten(int zahl, TestNr testNr)
    {
        var liste = Zahlen.PrimzahlenBerechnen(zahl);

        Assert.Equal(_primzahlen[(int) testNr], liste);
    }
}
