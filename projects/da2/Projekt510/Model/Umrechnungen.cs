using System.Collections.ObjectModel;

namespace Projekt510.Model;
public class Umrechnungen
{
    public enum Zahlensystem
    {
        BinaerC,
        BinaerPlc,
        HexadezimalC,
        HexadezimalPlc
    }

    public static (string sBin, ObservableCollection<HornerSchema> horner) DezimalToBinaer(int zahl, int anzahlByte, Zahlensystem zahlensystem)
    {
        _ = zahl;
        _ = anzahlByte;
        _ = zahlensystem;

        return ("", []);
    }
    public static (string sHex, ObservableCollection<HornerSchema> horner) DezimalToHexadezimal(int zahl, int anzahlByte, Zahlensystem zahlensystem)
    {
        _ = zahl;
        _ = anzahlByte;
        _ = zahlensystem;

        return ("", []);
    }
}
