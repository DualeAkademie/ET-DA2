// ReSharper disable UnusedMember.Global
namespace Projekt523.Model;

public class TrackPoint(double latitude, double longitude, double elevation)
{
    public double Latitude { get; set; } = latitude;
    public double Longitude { get; set; } = longitude;
    public double Elevation { get; set; } = elevation;
}
