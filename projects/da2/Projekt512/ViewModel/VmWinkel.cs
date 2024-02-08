using Projekt512.Model;

namespace Projekt512.ViewModel;
public partial class ViewModel
{
    public void Winkel3Aendern(BildDrehen.Winkel winkel)
    {
        _refreshArray3 = true;
        _winkel3 = winkel;
    }
    public void Winkel4Aendern(BildDrehen.Winkel winkel)
    {
        _refreshArray4 = true;
        _winkel4 = winkel;
    }
    public void Winkel5Aendern(BildDrehen.Winkel winkel)
    {
        _refreshArray5 = true;
        _winkel5 = winkel;
    }
    public void Winkel6Aendern(BildDrehen.Winkel winkel)
    {
        _refreshArray6 = true;
        _winkel6 = winkel;
    }
}
