// ReSharper disable UnusedMember.Global
namespace Projekt2001.Model;

public class SpielStein
{
    public enum Status
    {
        Leer,
        Gelb,
        Rot
    }

    public enum Gewinner
    {
        Leer,
        Gewonnen
    }

    // ReSharper disable once EmptyConstructor
    public SpielStein()
    {
        //
    }
}
