using Microsoft.Win32;
using System.IO;

namespace Projekt523.Model;

public partial class ModelGpx
{
    public GpxReader? GpxReader { get; set; }

    private string _gpsDateiName = string.Empty;

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

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
