using Projekt521.Model;

namespace Projekt521.Test;

public class PvTestenFixture
{
    public AlleDaten? AlleDaten { get; set; } = new();
}
public class PvTesten(PvTestenFixture fixture) : IClassFixture<PvTestenFixture>
{

    [Theory]
    [InlineData("-", "PV", "Photovoltaikanlage, Vorarlberg, Ost-West Ausrichtung")]

    public void TestPvBezeichnungen(string? url, string? kurzbez, string? langbez)
    {
        Assert.Equal(url, fixture.AlleDaten?.PvDaten?.Url);
        Assert.Equal(kurzbez, fixture.AlleDaten?.PvDaten?.Kurzbezeichnung);
        Assert.Equal(langbez, fixture.AlleDaten?.PvDaten?.Langbezeichnung);
    }


    [Theory]
    [InlineData(2022, 1, 1)]

    public void TestPv(int year, int month, int day)
    {
        var dateTime = new DateTime(year, month, day, 0, 0, 0);

        for (var i = 0; i < 365 * 4 * 24; i++)
        {
            var date = DateOnly.FromDateTime(dateTime);
            var time = TimeOnly.FromDateTime(dateTime);

            Assert.Equal(date, fixture.AlleDaten?.PvDaten?.Datenpunkte?[i].Date);
            Assert.Equal(time, fixture.AlleDaten?.PvDaten?.Datenpunkte?[i].Time);

            dateTime = dateTime.AddMinutes(15);
        }
    }
}
