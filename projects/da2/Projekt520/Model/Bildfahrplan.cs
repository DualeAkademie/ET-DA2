using Newtonsoft.Json;
using Projekt520.Daten;
using System.IO;
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

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


    public Bildfahrplan()
    {
        try
        {
            Bahnstrecke = JsonConvert.DeserializeObject<Bahnstrecke>(File.ReadAllText(@"Daten\Bahnstrecke_Lindau_Bludenz.json"));
            Fahrplanbild = JsonConvert.DeserializeObject<Fahrplanbild>(File.ReadAllText(@"Daten\\Fahrplanbilder.json"));

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public double[] GetTrasseStrecken(Trassen trasse)
    {
        _ = trasse;
        return null!;
    }

    public List<string> GetBahnhoefe(Trassen trasse)
    {
        _ = trasse;
        return null!;
    }
}
