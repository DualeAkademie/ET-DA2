namespace Projekt510.Model;
public class HornerSchema
{
    public string Schritt { get; set; }
    public int DezimaleZahl { get; set; }
    public string Rest { get; set; }

    public HornerSchema(string schritt, int dezimaleZahl, string rest)
    {
        Schritt = schritt;
        DezimaleZahl = dezimaleZahl;
        Rest = rest;
    }
}
