using static Projekt521.Model.AlleDaten;

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

namespace Projekt521.Daten;

public class ViertelStunde(DateTime dateTime)
{
    private readonly double[] _leistungDp = new double[1 + (int) LeistungsProfile.Pv];

    public void SetLeistung(LeistungsProfile profil, double leistungDp) => _leistungDp[(int) profil] = leistungDp;
    public DateTime GetTimeStamp() => dateTime;
    public DateOnly GetDate() => DateOnly.FromDateTime(dateTime);
    public TimeOnly GetTime() => TimeOnly.FromDateTime(dateTime);
    public double GetLeistung(LeistungsProfile profil) => _leistungDp[(int) profil];
}
