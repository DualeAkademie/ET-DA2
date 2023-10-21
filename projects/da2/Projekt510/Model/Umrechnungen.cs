using System.Collections.ObjectModel;

namespace Projekt510.Model;
public class Umrechnungen
{
    public enum HexadezimalStil
    {
        Plc,
        C
    }

    public static (string sBin, ObservableCollection<HornerSchema> horner) DezimalToBinaer(int zahl, int anzahlByte)
    {
        _ = zahl;
        _= anzahlByte;

        return ("", new ObservableCollection<HornerSchema>( ) );
    }
    public static (string sHex, ObservableCollection<HornerSchema> horner) DezimalToHexadezimal(int zahl, int anzahlByte, HexadezimalStil stil)
    {
        _ = zahl;
        _ = anzahlByte;
        _ = stil;

        return ("", new ObservableCollection<HornerSchema>());
    }
}
