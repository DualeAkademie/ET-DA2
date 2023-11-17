namespace Projekt512.Model;

public class BildDrehen
{
    public enum Winkel
    {
        Cw0 = 0,
        Cw90,
        Cw180,
        Cw270,
        Ccw0,
        Ccw90,
        Ccw180,
        Ccw270
    }

    // Es darf kein zweites Array für den Rückgabewert verwendet werden!
    public static int[,] BildRotieren(int[,] bild, Winkel winkel)
    {
        _ = winkel;
        return bild;
    }
}
