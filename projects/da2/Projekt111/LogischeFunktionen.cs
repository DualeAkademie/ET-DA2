namespace Projekt111;
public class LogischeFunktionen
{

    public enum LogischeOperationen
    {
        Und,
        Oder,
        Nicht,
        ExklusivOder
    }

    public static uint Funktionen(uint a, uint b, LogischeOperationen operation)
    {
        _ = a;
        _ = b;
        _ = operation;
        return 0;
    }
}
