namespace Projekt122.Test;
public class WallisschesProduktTesten
{
    [Theory]
    [InlineData(0, -5)]
    [InlineData(0, 0)]

    [InlineData(2.66666666669, 1)]
    [InlineData(2.84444444440, 2)]
    [InlineData(2.92571428569, 3)]
    [InlineData(2.97215419499, 4)]
    [InlineData(3.00217595460, 5)]
    [InlineData(3.02317019199, 6)]
    [InlineData(3.06770380660, 10)]
    [InlineData(3.10351696150, 20)]
    [InlineData(3.11594828590, 30)]
    [InlineData(3.12607890020, 50)]
    [InlineData(3.13378749061, 100)]
    [InlineData(3.13767790100, 200)]
    [InlineData(3.13898010390, 300)]
    [InlineData(3.14002381860, 500)]
    [InlineData(3.14080774600, 1000)]
    [InlineData(3.14120007720, 2000)]
    [InlineData(3.14133090870, 3000)]
    [InlineData(3.14143559359, 5000)]
    [InlineData(3.14151411870, 10000)]
    [InlineData(3.14155338489, 20000)]
    [InlineData(3.14156647420, 30000)]
    [InlineData(3.14157694579, 50000)]

    public void TestWallisschesProdukt(double exp, int zahl)
    {
        var anzahl = WallisschesProdukt.WallisschesProduktBerechnen(zahl);
        Assert.Equal(double.Round(exp, 10), double.Round(anzahl, 10));
    }

}
