namespace Projekt110.Test;

public class LaengeMonat
{
    [Theory]
    [InlineData(31, 2023, 1)]
    [InlineData(28, 2023, 2)]
    [InlineData(31, 2023, 3)]
    [InlineData(30, 2023, 4)]
    [InlineData(31, 2023, 5)]
    [InlineData(30, 2023, 6)]
    [InlineData(31, 2023, 7)]
    [InlineData(31, 2023, 8)]
    [InlineData(30, 2023, 9)]
    [InlineData(31, 2023, 10)]
    [InlineData(30, 2023, 11)]
    [InlineData(31, 2023, 12)]

    [InlineData(28, 1800, 2)]
    [InlineData(28, 1900, 2)]
    [InlineData(28, 2100, 2)]
    [InlineData(29, 2012, 2)]
    [InlineData(29, 2016, 2)]
    [InlineData(29, 2020, 2)]

    public void LaengeMonatMitAbfrage(int exp, int jahr, int monat)
    {
        var laenge = DatumKalender.LastDayOfMonth(jahr, monat);
        Assert.Equal(exp, laenge);
    }



    [Theory]
    [InlineData(31, 2023, 1)]
    [InlineData(28, 2023, 2)]
    [InlineData(31, 2023, 3)]
    [InlineData(30, 2023, 4)]
    [InlineData(31, 2023, 5)]
    [InlineData(30, 2023, 6)]
    [InlineData(31, 2023, 7)]
    [InlineData(31, 2023, 8)]
    [InlineData(30, 2023, 9)]
    [InlineData(31, 2023, 10)]
    [InlineData(30, 2023, 11)]
    [InlineData(31, 2023, 12)]

    [InlineData(28, 1800, 2)]
    [InlineData(28, 1900, 2)]
    [InlineData(28, 2100, 2)]
    [InlineData(29, 2012, 2)]
    [InlineData(29, 2016, 2)]
    [InlineData(29, 2020, 2)]

    public void LaengeMonatOhneAbfrage(int exp, int jahr, int monat)
    {
        var laenge = DatumKalender.DaysInMonth(jahr, monat);
        Assert.Equal(exp, laenge);
    }
}
