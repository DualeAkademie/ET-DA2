using Projekt520.Model;

namespace Projekt520.Test;

public class BahnstreckeBezeichnungenTesten
{
    [Theory]
    [InlineData("Bahnstrecke Lindau-Bludenz")]

    public static void TestBezeichnung(string? exp)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var bezeichnung = bildfahrplan.Bahnstrecke?.Bezeichnung;

        Assert.Equal(exp, bezeichnung);
    }


    [Theory]
    [InlineData("https://de.wikipedia.org/wiki/Bahnstrecke_Lindau%E2%80%93Bludenz")]
    public static void TestUrl(string? exp)
    {
        Bildfahrplan bildfahrplan = new Bildfahrplan();
        var url = bildfahrplan.Bahnstrecke?.Url;

        Assert.Equal(exp, url);
    }
}
