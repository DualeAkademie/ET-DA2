// ReSharper disable UnusedMember.Global
namespace Projekt511.Model;
public class StatistikWerk(char key, int anzahlDe, int anzahlEn, int anzahlFr, double prozentDe, double prozentEn, double prozentFr)
{
    public char Zeichen { get; set; } = key;
    public int AnzDe { get; set; } = anzahlDe;
    public int AnzEn { get; set; } = anzahlEn;
    public int AnzFr { get; set; } = anzahlFr;
    public double PrDe { get; set; } = prozentDe;
    public double PrEn { get; set; } = prozentEn;
    public double PrFr { get; set; } = prozentFr;
}
