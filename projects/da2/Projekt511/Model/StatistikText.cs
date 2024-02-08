// ReSharper disable UnusedMember.Global
namespace Projekt511.Model;
public class StatistikText(char key, int i, double prozent)
{
    public char Zeichen { get; set; } = key;
    public int Anzahl { get; set; } = i;
    public double Prozent { get; set; } = prozent;
}
