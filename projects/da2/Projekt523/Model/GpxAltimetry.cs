// ReSharper disable UnusedMember.Global
namespace Projekt523.Model;

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
public class Altimetry(double elevation, double kilometers)
{
    public double Elevation { get; set; } = elevation;
    public double Kilometers { get; set; } = kilometers;
}
