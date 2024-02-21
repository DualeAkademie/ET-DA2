// ReSharper disable UnusedMember.Global

namespace Projekt523.Model;

public partial class ModelGpx
{
    private GpxReader GpxDateiEinlesen()
    {
        var gpxReader = new GpxReader(_gpsDateiName);
        return gpxReader;
    }
    public void HoehenprofilAnzeigen()
    {
        //
    }
    public void GeschwindigkeitAnzeigen()
    {
//
    }
}
