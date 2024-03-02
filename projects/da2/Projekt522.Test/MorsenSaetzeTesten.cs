using System.Text;

namespace Projekt522.Test;
public class MorsenSaetzeTesten(MorsenTestenFixture fixture) : IClassFixture<MorsenTestenFixture>
{
    private const string Buchstabenabstand = "   ";
    private const string Wortabstand = "       ";

    [Theory]
    [InlineData("•" + Buchstabenabstand + "• •" + Buchstabenabstand + "— •" + Wortabstand + "• • •" + Buchstabenabstand + "• —" + Buchstabenabstand + "—" + Buchstabenabstand + "— — • •", "Ein Satz")]

    public void MorsenSaetzeTest(string exp, string? s)
    {
        var morsecode = fixture.ModelMorsen.GetMorsecodeSaetze(s);

        var alles = new StringBuilder("");
        foreach (var wortTuple in morsecode!)
        {
            _ = alles.Append(wortTuple.morsecode);
        }

        Assert.Equal(exp, alles.ToString());
    }
}
