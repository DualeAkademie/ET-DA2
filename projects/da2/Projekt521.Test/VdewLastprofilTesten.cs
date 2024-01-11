using Projekt521.Model;

namespace Projekt521.Test;

public class VdewLastprofilTesten(PvTestenFixture fixture) : IClassFixture<PvTestenFixture>
{
    [Theory]
    [InlineData(AlleDaten.LeistungsProfile.H0, "https://www.bdew.de/energie/standardlastprofile-strom/", "H0", "Haushalt")]
    [InlineData(AlleDaten.LeistungsProfile.G0, "https://www.bdew.de/energie/standardlastprofile-strom/", "G0", "Gewerbe allgemein")]
    [InlineData(AlleDaten.LeistungsProfile.G1, "https://www.bdew.de/energie/standardlastprofile-strom/", "G1", "Gewerbe werktags 8-18")]
    [InlineData(AlleDaten.LeistungsProfile.G2, "https://www.bdew.de/energie/standardlastprofile-strom/", "G2", "Gewerbe mit starkem bis überwiegendem Verbrauch in den Abendstunden")]
    [InlineData(AlleDaten.LeistungsProfile.G3, "https://www.bdew.de/energie/standardlastprofile-strom/", "G3", "Gewerbe durchlaufend")]
    [InlineData(AlleDaten.LeistungsProfile.G4, "https://www.bdew.de/energie/standardlastprofile-strom/", "G4", "Laden / Friseur")]
    [InlineData(AlleDaten.LeistungsProfile.G5, "https://www.bdew.de/energie/standardlastprofile-strom/", "G5", "Bäckerei mit Backstufe")]
    [InlineData(AlleDaten.LeistungsProfile.G6, "https://www.bdew.de/energie/standardlastprofile-strom/", "G6", "Wochenendbetrieb")]
    [InlineData(AlleDaten.LeistungsProfile.L0, "https://www.bdew.de/energie/standardlastprofile-strom/", "L0", "Landwirtschaftsbetrieb")]
    [InlineData(AlleDaten.LeistungsProfile.L1, "https://www.bdew.de/energie/standardlastprofile-strom/", "L1", "Landwirtschaftsbetrieb mit Milchwirtschaft / Nebenerwerbs-Tierzucht")]
    [InlineData(AlleDaten.LeistungsProfile.L2, "https://www.bdew.de/energie/standardlastprofile-strom/", "L2", "Übrige Landwirtschaftsbetriebe")]

    private void TestVdewBezeichnungen(AlleDaten.LeistungsProfile profil, string? url, string? kurzbez, string? langbez)
    {
        var intProfil = (int) profil;
        Assert.Equal(url, fixture.AlleDaten?.VdewLastprofile?.Url);
        Assert.Equal(kurzbez, fixture.AlleDaten?.VdewLastprofile?.VdewProfile?[intProfil].Kurzbezeichnung);
        Assert.Equal(langbez, fixture.AlleDaten?.VdewLastprofile?.VdewProfile?[intProfil].Langbezeichnung);
    }

    [Theory]
    [InlineData(2022, 1, 1)]
    public void TestVdewLastprofil(int year, int month, int day)
    {
        var dateTime = new DateTime(year, month, day, 0, 0, 0);

        for (var i = 0; i < 4 * 24; i++)
        {
            var time = TimeOnly.FromDateTime(dateTime);

            for (var j = 0; j <= (int) AlleDaten.LeistungsProfile.L2; j++) { Assert.Equal(time, fixture.AlleDaten?.VdewLastprofile?.VdewProfile?[j].TagesDaten?[i].Time); }

            dateTime = dateTime.AddMinutes(15);
        }
    }
}
