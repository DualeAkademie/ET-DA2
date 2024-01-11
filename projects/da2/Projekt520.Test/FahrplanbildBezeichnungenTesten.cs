using Projekt520.Model;

namespace Projekt520.Test;

public class FahrplanbildBezeichnungenTesten
{
    [Theory]
    [InlineData("Fahrplanbild 401")]
    public static void TestFahrplanbildBezeichnung(string? exp)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var bezeichnung = bildfahrplan.Fahrplanbild?.Bezeichnung;

        Assert.Equal(exp, bezeichnung);
    }

    [Theory]
    [InlineData("https://www.oebb.at/de/fahrplan/fahrplanbilder")]
    public static void TestFahrplanbildUrl(string? exp)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var url = bildfahrplan.Fahrplanbild?.Url;

        Assert.Equal(exp, url);
    }

    [Theory]
    [InlineData("S1", 0)]
    [InlineData("S1", 1)]
    [InlineData("REX1", 2)]
    [InlineData("REX1", 3)]
    public static void TestZugNamen(string? exp, int id)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var bezeichnung = bildfahrplan.Fahrplanbild?.Zuege?[id].Bezeichnung;

        Assert.Equal(exp, bezeichnung);
    }



    [Theory]
    [InlineData(25809, 0)]
    [InlineData(25802, 1)]
    [InlineData(5571, 2)]
    [InlineData(25802, 3)]
    public static void TestZugNummern(int exp, int id)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var nummer = bildfahrplan.Fahrplanbild?.Zuege?[id].Nummer;

        Assert.Equal(exp, nummer);
    }


    [Theory]
    [InlineData("Lindau-Bludenz", 0)]
    [InlineData("Bludenz-Lindau", 1)]
    [InlineData("Lindau-Bludenz", 2)]
    [InlineData("Bludenz-Lindau", 3)]
    public static void TestZugRichtung(string? exp, int id)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var richtung = bildfahrplan.Fahrplanbild?.Zuege?[id].Richtung;

        Assert.Equal(exp, richtung);
    }
}
