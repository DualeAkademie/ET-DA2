// ReSharper disable UnusedMember.Global
namespace Projekt523.GpxLib;

public class GpxAltimetry(
    double minElevation,
    double maxElevation,
    double avgElevation,
    IEnumerable<Altimetry> altimetries)
{
    public double MinElevation { get; set; } = minElevation;
    public double MaxElevation { get; set; } = maxElevation;
    public double AvgElevation { get; set; } = avgElevation;
    public IEnumerable<Altimetry> Altimetries { get; set; } = altimetries;
}

public class Altimetry(DateTime dateTime, double elevation, double kilometers, double speed)
{
    public DateTime DateTime { get; set; } = dateTime;
    public double Elevation { get; set; } = elevation;
    public double Kilometers { get; set; } = kilometers;
    public double Speed { get; set; } = speed;
}
