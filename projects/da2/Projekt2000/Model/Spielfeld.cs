using System.Windows.Input;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace Projekt2000.Model;


public class Spielfeld
{
    public enum Status
    {
        Leer,
        Kreis,
        Kreuz
    }
    public enum Gewinner
    {
        Leer,
        Gewonnen,
        Unentschieden
    }
    public Cursor CursorKreis = new("cursor\\kreis.cur");
    public Cursor CursorKreuz = new("cursor\\kreuz.cur");

    private const char SymbolKreuz = '\u2573';
    private const char SymbolKreis = '\u25EF';

    
    // ReSharper disable once EmptyConstructor
    public Spielfeld()
    {
        //
    }
}
