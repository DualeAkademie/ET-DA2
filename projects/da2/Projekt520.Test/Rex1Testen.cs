using Projekt520.Model;

namespace Projekt520.Test;
public class Rex1Testen
{
    [Theory]
    [InlineData("Lindau-Insel", Bildfahrplan.Trassen.Rex1Sued, 0)]
    [InlineData("Lindau-Reutin", Bildfahrplan.Trassen.Rex1Sued, 1)]
    [InlineData("Lochau-Hörbranz", Bildfahrplan.Trassen.Rex1Sued, 2)]
    [InlineData("Bregenz Hafen", Bildfahrplan.Trassen.Rex1Sued, 3)]
    [InlineData("Bregenz", Bildfahrplan.Trassen.Rex1Sued, 4)]
    [InlineData("Bregenz Riedenburg", Bildfahrplan.Trassen.Rex1Sued, 5)]
    [InlineData("Dornbirn", Bildfahrplan.Trassen.Rex1Sued, 6)]
    [InlineData("Hohenems", Bildfahrplan.Trassen.Rex1Sued, 7)]
    [InlineData("Götzis", Bildfahrplan.Trassen.Rex1Sued, 8)]
    [InlineData("Rankweil", Bildfahrplan.Trassen.Rex1Sued, 9)]
    [InlineData("Feldkirch", Bildfahrplan.Trassen.Rex1Sued, 10)]
    [InlineData("Frastanz", Bildfahrplan.Trassen.Rex1Sued, 11)]
    [InlineData("Nenzing", Bildfahrplan.Trassen.Rex1Sued, 12)]
    [InlineData("Bludenz", Bildfahrplan.Trassen.Rex1Sued, 13)]

    public static void TestHaltestellen(string? exp, Bildfahrplan.Trassen trasse, int id)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var haltestellen = bildfahrplan.GetBahnhoefe(trasse);

        Assert.Equal(exp, haltestellen?[id]);
    }

    [Theory]
    [InlineData(0, Bildfahrplan.Trassen.Rex1Sued, 0)]
    [InlineData(2.46, Bildfahrplan.Trassen.Rex1Sued, 1)]
    [InlineData(6.716, Bildfahrplan.Trassen.Rex1Sued, 2)]
    [InlineData(9.6, Bildfahrplan.Trassen.Rex1Sued, 3)]
    [InlineData(10.405, Bildfahrplan.Trassen.Rex1Sued, 4)]
    [InlineData(12.7, Bildfahrplan.Trassen.Rex1Sued, 5)]
    [InlineData(22.233, Bildfahrplan.Trassen.Rex1Sued, 6)]
    [InlineData(30.121, Bildfahrplan.Trassen.Rex1Sued, 7)]
    [InlineData(34.760, Bildfahrplan.Trassen.Rex1Sued, 8)]
    [InlineData(42.518, Bildfahrplan.Trassen.Rex1Sued, 9)]
    [InlineData(46.912, Bildfahrplan.Trassen.Rex1Sued, 10)]
    [InlineData(51.387, Bildfahrplan.Trassen.Rex1Sued, 11)]
    [InlineData(57.739, Bildfahrplan.Trassen.Rex1Sued, 12)]
    [InlineData(67.746, Bildfahrplan.Trassen.Rex1Sued, 13)]

    public static void TestTrassen(double exp, Bildfahrplan.Trassen trasse, int id)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var trassen = bildfahrplan.GetTrasseStrecken(trasse);

        Assert.Equal(exp, trassen?[2 * id]);
    }
}
