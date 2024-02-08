using Projekt512.Model;

namespace Projekt512.ViewModel;
public partial class ViewModel
{
    private void RefreshArray3()
    {
        if (!_refreshArray3) { return; }

        _refreshArray3 = false;

        var ergebnis3 = BildDrehen.BildRotieren(_arrayAngabe3, _winkel3);
        Ae00 = ergebnis3[0, 0];
        Ae01 = ergebnis3[0, 1];
        Ae02 = ergebnis3[0, 2];
        Ae10 = ergebnis3[1, 0];
        Ae11 = ergebnis3[1, 1];
        Ae12 = ergebnis3[1, 2];
        Ae20 = ergebnis3[2, 0];
        Ae21 = ergebnis3[2, 1];
        Ae22 = ergebnis3[2, 2];
    }
    private void RefreshArray4()
    {
        if (!_refreshArray4) { return; }

        _refreshArray4 = false;

        var ergebnis4 = BildDrehen.BildRotieren(_arrayAngabe4, _winkel4);
        Be00 = ergebnis4[0, 0];
        Be01 = ergebnis4[0, 1];
        Be02 = ergebnis4[0, 2];
        Be03 = ergebnis4[0, 3];
        Be10 = ergebnis4[1, 0];
        Be11 = ergebnis4[1, 1];
        Be12 = ergebnis4[1, 2];
        Be13 = ergebnis4[1, 3];
        Be20 = ergebnis4[2, 0];
        Be21 = ergebnis4[2, 1];
        Be22 = ergebnis4[2, 2];
        Be23 = ergebnis4[2, 3];
        Be30 = ergebnis4[3, 0];
        Be31 = ergebnis4[3, 1];
        Be32 = ergebnis4[3, 2];
        Be33 = ergebnis4[3, 3];
    }
    private void RefreshArray5()
    {
        if (!_refreshArray5) { return; }

        _refreshArray5 = false;

        var ergebnis5 = BildDrehen.BildRotieren(_arrayAngabe5, _winkel5);
        Ce00 = ergebnis5[0, 0];
        Ce01 = ergebnis5[0, 1];
        Ce02 = ergebnis5[0, 2];
        Ce03 = ergebnis5[0, 3];
        Ce04 = ergebnis5[0, 4];
        Ce10 = ergebnis5[1, 0];
        Ce11 = ergebnis5[1, 1];
        Ce12 = ergebnis5[1, 2];
        Ce13 = ergebnis5[1, 3];
        Ce14 = ergebnis5[1, 4];
        Ce20 = ergebnis5[2, 0];
        Ce21 = ergebnis5[2, 1];
        Ce22 = ergebnis5[2, 2];
        Ce23 = ergebnis5[2, 3];
        Ce24 = ergebnis5[2, 4];
        Ce30 = ergebnis5[3, 0];
        Ce31 = ergebnis5[3, 1];
        Ce32 = ergebnis5[3, 2];
        Ce33 = ergebnis5[3, 3];
        Ce34 = ergebnis5[3, 4];
        Ce40 = ergebnis5[4, 0];
        Ce41 = ergebnis5[4, 1];
        Ce42 = ergebnis5[4, 2];
        Ce43 = ergebnis5[4, 3];
        Ce44 = ergebnis5[4, 4];
    }
    private void RefreshArray6()
    {
        if (!_refreshArray6) { return; }

        _refreshArray6 = false;

        var ergebnis6 = BildDrehen.BildRotieren(_arrayAngabe6, _winkel6);
        De00 = ergebnis6[0, 0];
        De01 = ergebnis6[0, 1];
        De02 = ergebnis6[0, 2];
        De03 = ergebnis6[0, 3];
        De04 = ergebnis6[0, 4];
        De05 = ergebnis6[0, 5];
        De10 = ergebnis6[1, 0];
        De11 = ergebnis6[1, 1];
        De12 = ergebnis6[1, 2];
        De13 = ergebnis6[1, 3];
        De14 = ergebnis6[1, 4];
        De15 = ergebnis6[1, 5];
        De20 = ergebnis6[2, 0];
        De21 = ergebnis6[2, 1];
        De22 = ergebnis6[2, 2];
        De23 = ergebnis6[2, 3];
        De24 = ergebnis6[2, 4];
        De25 = ergebnis6[2, 5];
        De30 = ergebnis6[3, 0];
        De31 = ergebnis6[3, 1];
        De32 = ergebnis6[3, 2];
        De33 = ergebnis6[3, 3];
        De34 = ergebnis6[3, 4];
        De35 = ergebnis6[3, 5];
        De40 = ergebnis6[4, 0];
        De41 = ergebnis6[4, 1];
        De42 = ergebnis6[4, 2];
        De43 = ergebnis6[4, 3];
        De44 = ergebnis6[4, 4];
        De45 = ergebnis6[4, 5];
        De50 = ergebnis6[5, 0];
        De51 = ergebnis6[5, 1];
        De52 = ergebnis6[5, 2];
        De53 = ergebnis6[5, 3];
        De54 = ergebnis6[5, 4];
        De55 = ergebnis6[5, 5];
    }
}
