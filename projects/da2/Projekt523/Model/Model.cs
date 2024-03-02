using Microsoft.Win32;
using Projekt523.GpxLib;
using System.IO;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable MemberCanBeMadeStatic.Local
#pragma warning disable CS0169 // Field is never used
#pragma warning disable IDE0051
#pragma warning disable IDE0044

namespace Projekt523.Model;

public class Model
{
    public enum MittelwertType
    {
        KeinMittelwert,
        CumulativeMovingAverage,
        SimpleMovingAverage,
        ExponentialMovingAverage
    }

    public GpxReader? GpxReader { get; set; }
    public bool MittelwertAnzeigen { get; set; }
    public double[]? StreckenAchse { get; set; }
    public DateTime[]? ZeitAchse { get; set; }
    public double[]? HohenProfil { get; set; }
    public double[]? GeschwindigkeitsProfil { get; set; }
    public double[]? GeschwindigkeitMittelwert { get; set; }
    public double[]? BeschleunigungProfil { get; set; }
    public MittelwertType TypeMittelwert { get; set; }

    private string? _gpsDateiName = string.Empty;
    private string? _gpsTrackName = string.Empty;

    private GpxAltimetry? _gpsAltimetry;


    private int _mittelwertNumber;
    private int _beschleunigung;

    private GpxReader? GpxDateiEinlesen() => _gpsDateiName == null ? null : new GpxReader(_gpsDateiName);

    public void GpxDateiOeffnen()
    {
        var aktuellerOrdner = Directory.GetCurrentDirectory();

        try
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(aktuellerOrdner, "GpsDaten"),
                DefaultExt = "gpx"
            };

            if (openFileDialog.ShowDialog() != true) { return; }

            _gpsDateiName = openFileDialog.FileName;

            GpxReader = GpxDateiEinlesen();


            //

            MittelwertBerechnen();
            BeschleunigungBerechnen();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public void SetNeuerMittelwert(string? type, int num, int beschleunigung)
    {
        _ = type;
        _ = num;
        _= beschleunigung;

        MittelwertBerechnen();
        BeschleunigungBerechnen();
    }
    private void MittelwertBerechnen()
    {
      //
    }
    private void BeschleunigungBerechnen()
    {
      //
    }
}
