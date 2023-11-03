namespace Projekt115;

public class ZahlenKonvertieren
{
    /*
     * Ausgabe:
     *      BinärC:         0b0000  --> Anzahl der Stellen immer als Vielfaches von 4
     *      BinärPlc:       2#0000
     *      HexadezimalC:   0x0
     *      HexadezimalPlc: 16#0
     *      OktalC:         00
     *      OktalPlc:       8#0
     *      Dezimal:        0
     *
     * Eingabe:
     *      Binär:          0b oder 2#
     *      Hexadezimal:    0x oder 16#
     *      Oktal:          führende 0 oder 8#
     *      Dezimal:        keine führende 0
     */

    public enum Zahlensystem
    {
        BinaerC,
        BinaerPlc,
        Dezimal,
        HexadezimalC,
        HexadezimalPlc,
        OktalC,
        OktalPlc
    }

    public static string ZahlensystemKonvertieren(string zahl, Zahlensystem zahlensystem)
    {
        _ = zahl;
        _ = zahlensystem;
        return "-";
    }

}
