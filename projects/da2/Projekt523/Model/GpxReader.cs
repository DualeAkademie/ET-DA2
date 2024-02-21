// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Local
#pragma warning disable CS0169 // Field is never used

using System.Xml;
using System.Xml.Linq;
// ReSharper disable RedundantJumpStatement


namespace Projekt523.Model;
public class GpxReader
{
    public enum ElevationType { Min, Max, Avg }

    private readonly XDocument? _gpx;


    private readonly string? _gpxName;
    private readonly double _minElevation;
    private readonly double _maxElevation;
    private readonly double _avgElevation;

    private readonly DateTime _startDt;
    private readonly DateTime _endDt;
    private readonly TimeSpan _duration;

    private readonly GpxAltimetry? _gpxAltimetry;

    public GpxReader(string gpsDateiName)
    {
        _gpx = XDocument.Load(gpsDateiName);


        XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
        xmlNamespaceManager.AddNamespace("p", "http://www.topografix.com/GPX/1/1");




        return;
        /*
         * Hier endet die Implementierung des Konstruktors!
         */

    }
}
