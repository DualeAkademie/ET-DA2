namespace Projekt111;

public class Bitfunktionen
{
    public enum BitBefehl
    {
        BitGesetzt,
        BitNichtGesetzt,
        BitSetzen,
        BitLoeschen
    }

    public static bool BitTesten(uint wert, int position, BitBefehl befehl)
    {
        _ = wert;
        _ = position;
        _ = befehl;
        return false;
    }

    public static uint BitManipulieren(uint wert, int position, BitBefehl befehl)
    {
        _ = wert;
        _ = position;
        _ = befehl;
        return 0;
    }
}
