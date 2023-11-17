namespace Projekt510.Model;
public class HornerSchema(string schritt, int dezimaleZahl, string rest)
{
    public string Schritt { get; set; } = schritt;
    public int DezimaleZahl { get; set; } = dezimaleZahl;
    public string Rest { get; set; } = rest;
}
