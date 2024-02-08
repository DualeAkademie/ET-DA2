using Newtonsoft.Json;
using Projekt521.Daten;
using System.IO;

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

namespace Projekt521.Model;

public partial class AlleDaten
{
    public enum LeistungsProfile
    {
        H0,
        G0, G1, G2, G3, G4, G5, G6,
        L0, L1, L2,
        Wp,
        Pv
    }
    public enum SaisonTag
    {
        WinterSamstag,
        WinterSonntag,
        WinterWerktag,
        SommerSamtag,
        SommerSonntag,
        SommerWerktag,
        UebergangszeitSamstag,
        UebergangszeitSonntag,
        UebergangszeitWerktag
    }

    private const int EinJahr = 365 * 24 * 4;

    public ViertelStunde[] AlleViertelStunden = new ViertelStunde[EinJahr];
    public DateTime ErsterTag = new(2022, 1, 1, 0, 0, 0);
    public DateOnly WinterEnde = new(2022, 3, 20);
    public DateOnly WinterBeginn = new(2022, 11, 1);
    public DateOnly SommerBeginn = new(2022, 5, 15);
    public DateOnly SommerEnde = new(2022, 9, 14);

    public PvWp? PvDaten { get; set; }
    public PvWp? WpDaten { get; set; }
    public VdewLastProfile? VdewLastprofile { get; set; }

    public readonly double[] GesamtenergieVdew = new double[1 + (int) LeistungsProfile.Pv];
    public readonly double[] MaximalLeistungVdew = new double[1 + (int) LeistungsProfile.Pv];

    public AlleDaten()
    {
        try
        {
            PvDaten = JsonConvert.DeserializeObject<PvWp>(File.ReadAllText(@"Daten\PvDaten.json"));
            WpDaten = JsonConvert.DeserializeObject<PvWp>(File.ReadAllText(@"Daten\WpDaten.json"));
            VdewLastprofile = JsonConvert.DeserializeObject<VdewLastProfile>(File.ReadAllText(@"Daten\VdewLastprofile.json"));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}
