namespace Projekt521.Test;

public class WpTesten(PvTestenFixture fixture) : IClassFixture<PvTestenFixture>
{
    [Theory]
    [InlineData("https://www.bdew.de/energie/standardlastprofile-strom/", "WP", "Wärmepumpe")]

    public void TestWpBezeichnungen(string? url, string? kurzbez, string? langbez)
    {
        Assert.Equal(url, fixture.AlleDaten?.WpDaten?.Url);
        Assert.Equal(kurzbez, fixture.AlleDaten?.WpDaten?.Kurzbezeichnung);
        Assert.Equal(langbez, fixture.AlleDaten?.WpDaten?.Langbezeichnung);
    }

    [Fact]
    public void TestWp()
    {
        var dateTime = new DateTime(2022, 1, 1, 0, 0, 0);

        for (var i = 0; i < 365 * 4 * 24; i++)
        {
            var date = DateOnly.FromDateTime(dateTime);
            var time = TimeOnly.FromDateTime(dateTime);

            Assert.Equal(date, fixture.AlleDaten?.WpDaten?.Datenpunkte?[i].Date);
            Assert.Equal(time, fixture.AlleDaten?.WpDaten?.Datenpunkte?[i].Time);

            dateTime = dateTime.AddMinutes(15);
        }
    }
}
