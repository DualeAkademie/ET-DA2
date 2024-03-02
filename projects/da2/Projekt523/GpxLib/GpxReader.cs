using System.Globalization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
// ReSharper disable UnusedMember.Global

namespace Projekt523.GpxLib;
public class GpxReader
{
    public enum ElevationType { Min, Max, Avg }

    private readonly XDocument? _gpx;
    private readonly XmlNamespaceManager _xmlNamespaceManager;

    public GpxReader(string gpsDateiName)
    {
        _gpx = XDocument.Load(gpsDateiName);

        _xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
        _xmlNamespaceManager.AddNamespace("p", "http://www.topografix.com/GPX/1/1");
    }

    public string? GetGpxName() => _gpx?.XPathSelectElement("//p:gpx//p:trk//p:name", _xmlNamespaceManager)?.Value;
    public double GetElevation(ElevationType elevationType)
    {
        if (_gpx is null) { return 0; }

        return elevationType switch
        {
            ElevationType.Min => _gpx
                .XPathSelectElements("//p:gpx//p:trk//p:trkseg//p:trkpt//p:ele", _xmlNamespaceManager)
                .Min(x => double.Parse(x.Value, CultureInfo.InvariantCulture)),
            ElevationType.Max => _gpx
                .XPathSelectElements("//p:gpx//p:trk//p:trkseg//p:trkpt//p:ele", _xmlNamespaceManager)
                .Max(x => double.Parse(x.Value, CultureInfo.InvariantCulture)),
            ElevationType.Avg => _gpx
                .XPathSelectElements("//p:gpx//p:trk//p:trkseg//p:trkpt//p:ele", _xmlNamespaceManager)
                .Average(x => double.Parse(x.Value, CultureInfo.InvariantCulture)),
            _ => 0.0
        };
    }
    public static double GetDistance(double latitude, double longitude, double latitude2, double longitude2)
    {
        const double minutesPerDegree = 60;
        const double statusMilesPerNaticalMiles = 1.1515;
        const double milesPerKilometer = 1.609344;

        const double tolerance = 1e-9;

        if (Math.Abs(latitude - latitude2) < tolerance && Math.Abs(longitude - longitude2) < tolerance) { return 0; }

        var rlat1 = Math.PI * latitude / 180;
        var rlat2 = Math.PI * latitude2 / 180;
        var theta = longitude - longitude2;
        var rtheta = Math.PI * theta / 180;
        var distance =
            Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
            Math.Cos(rlat2) * Math.Cos(rtheta);

        distance = distance switch
        {
            > 1 => 1,
            < -1 => -1,
            _ => distance
        };

        distance = Math.Acos(distance);
        distance = distance * 180 / Math.PI;

        return distance * minutesPerDegree * statusMilesPerNaticalMiles * milesPerKilometer;
    }
    public IEnumerable<GpxTrackPoint> GetGpxCoordinates()
    {
        var xTrackPoints = _gpx!.XPathSelectElements("//p:gpx//p:trk//p:trkseg//p:trkpt", _xmlNamespaceManager);
        List<GpxTrackPoint> trackPoints = [];

        foreach (var xTrackPoint in xTrackPoints)
        {
            if (xTrackPoint.Attribute("lat") is null || xTrackPoint.Attribute("lon") is null) { continue; }
            if (xTrackPoint.Attribute("lat")?.Value is null || xTrackPoint.Attribute("lon")?.Value is null) { continue; }

            var latitude = double.Parse(xTrackPoint.Attribute("lat")?.Value!, CultureInfo.InvariantCulture);
            var longitude = double.Parse(xTrackPoint.Attribute("lon")?.Value!, CultureInfo.InvariantCulture);

            double elevation = default;
            var eleXElement = xTrackPoint.XPathSelectElement("p:ele", _xmlNamespaceManager);

            if (eleXElement is not null) { elevation = double.Parse(eleXElement.Value, CultureInfo.InvariantCulture); }
            else
            {
                if (trackPoints.Count > 0) { elevation = trackPoints.Last().Elevation; }
            }

            DateTime dateTime = default;
            var timeXElement = xTrackPoint.XPathSelectElement("p:time", _xmlNamespaceManager);

            if (timeXElement is not null) { dateTime = DateTime.Parse(timeXElement.Value, CultureInfo.InvariantCulture); }
            else
            {
                if (trackPoints.Count > 0) { dateTime = trackPoints.Last().DateTime; }
            }

            trackPoints.Add(new GpxTrackPoint(latitude, longitude, elevation, dateTime));
        }

        return trackPoints;
    }
    public GpxAltimetry GetGpxAltimetry()
    {
        var minElevation = GetElevation(ElevationType.Min);
        var maxElevation = GetElevation(ElevationType.Max);
        var avgElevation = GetElevation(ElevationType.Avg);

        List<Altimetry> altimetries = [];
        GpxTrackPoint? previousTrackPoint = null;

        foreach (var trackPoint in GetGpxCoordinates())
        {
            previousTrackPoint ??= trackPoint;

            var distance = GetDistance(previousTrackPoint.Latitude, previousTrackPoint.Longitude, trackPoint.Latitude, trackPoint.Longitude);
            var lastDistanceValue = altimetries.LastOrDefault() is null ? 0.0 : altimetries.Last().Kilometers;
            var actualDistance = distance + lastDistanceValue;

            double actualSpeed = 0;
            TimeSpan timeTraveled = trackPoint.DateTime - previousTrackPoint.DateTime;
            if (timeTraveled > TimeSpan.Zero) { actualSpeed = 3600 * distance / timeTraveled.TotalSeconds; }

            altimetries.Add(new Altimetry(trackPoint.DateTime, trackPoint.Elevation, actualDistance, actualSpeed));

            previousTrackPoint = trackPoint;
        }

        return new GpxAltimetry(minElevation, maxElevation, avgElevation, altimetries);
    }
}

