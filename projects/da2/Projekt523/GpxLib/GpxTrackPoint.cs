namespace Projekt523.GpxLib;

public class GpxTrackPoint(double latitude, double longitude, double elevation, DateTime dateTime)
{
    public double Latitude { get; set; } = latitude;
    public double Longitude { get; set; } = longitude;
    public double Elevation { get; set; } = elevation;
    public DateTime DateTime { get; set; } = dateTime;
}
