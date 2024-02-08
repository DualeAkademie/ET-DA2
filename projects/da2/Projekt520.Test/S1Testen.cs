using Projekt520.Model;

namespace Projekt520.Test;
public class S1NamenTesten
{
    [Theory]
    [InlineData("Lindau-Insel", Bildfahrplan.Trassen.S1Sued, 0)]
    [InlineData("Lindau-Reutin", Bildfahrplan.Trassen.S1Sued, 1)]
    [InlineData("Lochau-Hörbranz", Bildfahrplan.Trassen.S1Sued, 2)]
    [InlineData("Bregenz Hafen", Bildfahrplan.Trassen.S1Sued, 3)]
    [InlineData("Bregenz", Bildfahrplan.Trassen.S1Sued, 4)]
    [InlineData("Bregenz Riedenburg", Bildfahrplan.Trassen.S1Sued, 5)]
    [InlineData("Lauterach", Bildfahrplan.Trassen.S1Sued, 6)]
    [InlineData("Wolfurt", Bildfahrplan.Trassen.S1Sued, 7)]
    [InlineData("Schwarzach in Vorarlberg", Bildfahrplan.Trassen.S1Sued, 8)]
    [InlineData("Haselstauden", Bildfahrplan.Trassen.S1Sued, 9)]
    [InlineData("Dornbirn", Bildfahrplan.Trassen.S1Sued, 10)]
    [InlineData("Dornbirn-Schoren", Bildfahrplan.Trassen.S1Sued, 11)]
    [InlineData("Hatlerdorf", Bildfahrplan.Trassen.S1Sued, 12)]
    [InlineData("Hohenems", Bildfahrplan.Trassen.S1Sued, 13)]
    [InlineData("Altach", Bildfahrplan.Trassen.S1Sued, 14)]
    [InlineData("Götzis", Bildfahrplan.Trassen.S1Sued, 15)]
    [InlineData("Klaus in Vorarlberg", Bildfahrplan.Trassen.S1Sued, 16)]
    [InlineData("Sulz-Röthis", Bildfahrplan.Trassen.S1Sued, 17)]
    [InlineData("Rankweil", Bildfahrplan.Trassen.S1Sued, 18)]
    [InlineData("Feldkirch-Amberg", Bildfahrplan.Trassen.S1Sued, 19)]
    [InlineData("Feldkirch", Bildfahrplan.Trassen.S1Sued, 20)]
    [InlineData("Frastanz", Bildfahrplan.Trassen.S1Sued, 21)]
    [InlineData("Schlins-Beschling", Bildfahrplan.Trassen.S1Sued, 22)]
    [InlineData("Nenzing", Bildfahrplan.Trassen.S1Sued, 23)]
    [InlineData("Ludesch", Bildfahrplan.Trassen.S1Sued, 24)]
    [InlineData("Nüziders", Bildfahrplan.Trassen.S1Sued, 25)]
    [InlineData("Bludenz", Bildfahrplan.Trassen.S1Sued, 26)]

    public static void TestHaltestellen(string? exp, Bildfahrplan.Trassen trasse, int id)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var haltestellen = bildfahrplan.GetBahnhoefe(trasse);

        Assert.Equal(exp, haltestellen[id]);
    }


    [Theory]
    [InlineData(0, Bildfahrplan.Trassen.S1Sued, 0)]
    [InlineData(2.46, Bildfahrplan.Trassen.S1Sued, 1)]
    [InlineData(6.716, Bildfahrplan.Trassen.S1Sued, 2)]
    [InlineData(9.6, Bildfahrplan.Trassen.S1Sued, 3)]
    [InlineData(10.405, Bildfahrplan.Trassen.S1Sued, 4)]
    [InlineData(12.7, Bildfahrplan.Trassen.S1Sued, 5)]
    [InlineData(14.196, Bildfahrplan.Trassen.S1Sued, 6)]
    [InlineData(16.98, Bildfahrplan.Trassen.S1Sued, 7)]
    [InlineData(18.62, Bildfahrplan.Trassen.S1Sued, 8)]
    [InlineData(20.248, Bildfahrplan.Trassen.S1Sued, 9)]
    [InlineData(22.233, Bildfahrplan.Trassen.S1Sued, 10)]
    [InlineData(23.32, Bildfahrplan.Trassen.S1Sued, 11)]
    [InlineData(25.138, Bildfahrplan.Trassen.S1Sued, 12)]
    [InlineData(30.121, Bildfahrplan.Trassen.S1Sued, 13)]
    [InlineData(32.214, Bildfahrplan.Trassen.S1Sued, 14)]
    [InlineData(34.76, Bildfahrplan.Trassen.S1Sued, 15)]
    [InlineData(38.145, Bildfahrplan.Trassen.S1Sued, 16)]
    [InlineData(39.998, Bildfahrplan.Trassen.S1Sued, 17)]
    [InlineData(42.518, Bildfahrplan.Trassen.S1Sued, 18)]
    [InlineData(44.855, Bildfahrplan.Trassen.S1Sued, 19)]
    [InlineData(46.912, Bildfahrplan.Trassen.S1Sued, 20)]
    [InlineData(51.387, Bildfahrplan.Trassen.S1Sued, 21)]
    [InlineData(56.198, Bildfahrplan.Trassen.S1Sued, 22)]
    [InlineData(57.739, Bildfahrplan.Trassen.S1Sued, 23)]
    [InlineData(63.327, Bildfahrplan.Trassen.S1Sued, 24)]
    [InlineData(65.224, Bildfahrplan.Trassen.S1Sued, 25)]
    [InlineData(67.746, Bildfahrplan.Trassen.S1Sued, 26)]

    public static void TestTrassen(double exp, Bildfahrplan.Trassen trassen, int id)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var trasse = bildfahrplan.GetTrasseStrecken(trassen);

        Assert.Equal(exp, trasse[2 * id]);
    }
}
