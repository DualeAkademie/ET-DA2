using Projekt520.Daten;

namespace Projekt520.Model;

public partial class Bildfahrplan
{
    public enum Trassen
    {
        S1Sued,
        S1Nord,
        Rex1Sued,
        Rex1Nord
    }

    public Bahnstrecke? Bahnstrecke { get; set; }
    public Fahrplanbild? Fahrplanbild { get; set; }
    
    // ReSharper disable once EmptyConstructor
    public Bildfahrplan()
    {
        // Bahnstrecke
    }
    public double[]? GetTrasseStrecken(Trassen trasse)
    {
        _ = trasse;
        return null;
    }
    public double PosBestimmen(string? name)
    {
        _ = name;
        return 0;
    }
    public List<string>? GetBahnhoefe(Trassen trasse)
    {
        _ = trasse;
        return null;
    }
}
