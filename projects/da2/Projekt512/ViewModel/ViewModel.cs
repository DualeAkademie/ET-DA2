using CommunityToolkit.Mvvm.ComponentModel;
using Projekt512.Model;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt512.ViewModel;

public partial class ViewModel : ObservableObject
{
    private readonly int[,] _arrayAngabe3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    private readonly int[,] _arrayAngabe4 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
    private readonly int[,] _arrayAngabe5 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
    private readonly int[,] _arrayAngabe6 = { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24 }, { 25, 26, 27, 28, 29, 30 }, { 31, 32, 33, 34, 35, 36 } };

    private BildDrehen.Winkel _winkel3 = BildDrehen.Winkel.Ccw0;
    private BildDrehen.Winkel _winkel4 = BildDrehen.Winkel.Ccw0;
    private BildDrehen.Winkel _winkel5 = BildDrehen.Winkel.Ccw0;
    private BildDrehen.Winkel _winkel6 = BildDrehen.Winkel.Ccw0;

    private bool _refresh3;
    private bool _refresh4;
    private bool _refresh5;
    private bool _refresh6;

    public ViewModel(CancellationTokenSource cancellationTokenSource)
    {
        Aa00 = _arrayAngabe3[0, 0];
        Aa01 = _arrayAngabe3[0, 1];
        Aa02 = _arrayAngabe3[0, 2];
        Aa10 = _arrayAngabe3[1, 0];
        Aa11 = _arrayAngabe3[1, 1];
        Aa12 = _arrayAngabe3[1, 2];
        Aa20 = _arrayAngabe3[2, 0];
        Aa21 = _arrayAngabe3[2, 1];
        Aa22 = _arrayAngabe3[2, 2];

        Ba00 = _arrayAngabe4[0, 0];
        Ba01 = _arrayAngabe4[0, 1];
        Ba02 = _arrayAngabe4[0, 2];
        Ba03 = _arrayAngabe4[0, 3];
        Ba10 = _arrayAngabe4[1, 0];
        Ba11 = _arrayAngabe4[1, 1];
        Ba12 = _arrayAngabe4[1, 2];
        Ba13 = _arrayAngabe4[1, 3];
        Ba20 = _arrayAngabe4[2, 0];
        Ba21 = _arrayAngabe4[2, 1];
        Ba22 = _arrayAngabe4[2, 2];
        Ba23 = _arrayAngabe4[2, 3];
        Ba30 = _arrayAngabe4[3, 0];
        Ba31 = _arrayAngabe4[3, 1];
        Ba32 = _arrayAngabe4[3, 2];
        Ba33 = _arrayAngabe4[3, 3];

        Ca00 = _arrayAngabe5[0, 0];
        Ca01 = _arrayAngabe5[0, 1];
        Ca02 = _arrayAngabe5[0, 2];
        Ca03 = _arrayAngabe5[0, 3];
        Ca04 = _arrayAngabe5[0, 4];
        Ca10 = _arrayAngabe5[1, 0];
        Ca11 = _arrayAngabe5[1, 1];
        Ca12 = _arrayAngabe5[1, 2];
        Ca13 = _arrayAngabe5[1, 3];
        Ca14 = _arrayAngabe5[1, 4];
        Ca20 = _arrayAngabe5[2, 0];
        Ca21 = _arrayAngabe5[2, 1];
        Ca22 = _arrayAngabe5[2, 2];
        Ca23 = _arrayAngabe5[2, 3];
        Ca24 = _arrayAngabe5[2, 4];
        Ca30 = _arrayAngabe5[3, 0];
        Ca31 = _arrayAngabe5[3, 1];
        Ca32 = _arrayAngabe5[3, 2];
        Ca33 = _arrayAngabe5[3, 3];
        Ca34 = _arrayAngabe5[3, 4];
        Ca40 = _arrayAngabe5[4, 0];
        Ca41 = _arrayAngabe5[4, 1];
        Ca42 = _arrayAngabe5[4, 2];
        Ca43 = _arrayAngabe5[4, 3];
        Ca44 = _arrayAngabe5[4, 4];

        Da00 = _arrayAngabe6[0, 0];
        Da01 = _arrayAngabe6[0, 1];
        Da02 = _arrayAngabe6[0, 2];
        Da03 = _arrayAngabe6[0, 3];
        Da04 = _arrayAngabe6[0, 4];
        Da05 = _arrayAngabe6[0, 5];
        Da10 = _arrayAngabe6[1, 0];
        Da11 = _arrayAngabe6[1, 1];
        Da12 = _arrayAngabe6[1, 2];
        Da13 = _arrayAngabe6[1, 3];
        Da14 = _arrayAngabe6[1, 4];
        Da15 = _arrayAngabe6[1, 5];
        Da20 = _arrayAngabe6[2, 0];
        Da21 = _arrayAngabe6[2, 1];
        Da22 = _arrayAngabe6[2, 2];
        Da23 = _arrayAngabe6[2, 3];
        Da24 = _arrayAngabe6[2, 4];
        Da25 = _arrayAngabe6[2, 5];
        Da30 = _arrayAngabe6[3, 0];
        Da31 = _arrayAngabe6[3, 1];
        Da32 = _arrayAngabe6[3, 2];
        Da33 = _arrayAngabe6[3, 3];
        Da34 = _arrayAngabe6[3, 4];
        Da35 = _arrayAngabe6[3, 5];
        Da40 = _arrayAngabe6[4, 0];
        Da41 = _arrayAngabe6[4, 1];
        Da42 = _arrayAngabe6[4, 2];
        Da43 = _arrayAngabe6[4, 3];
        Da44 = _arrayAngabe6[4, 4];
        Da45 = _arrayAngabe6[4, 5];
        Da50 = _arrayAngabe6[5, 0];
        Da51 = _arrayAngabe6[5, 1];
        Da52 = _arrayAngabe6[5, 2];
        Da53 = _arrayAngabe6[5, 3];
        Da54 = _arrayAngabe6[5, 4];
        Da55 = _arrayAngabe6[5, 5];

        _ = Task.Run(() => ViewModelTask(cancellationTokenSource.Token));
    }

    private void ViewModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            if (_refresh3)
            {
                _refresh3 = false;

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

            if (_refresh4)
            {
                _refresh4 = false;

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

            if (_refresh5)
            {
                _refresh5 = false;

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


            if (_refresh6)
            {
                _refresh6 = false;

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

            Thread.Sleep(100);
        }
    }
    public void Winkel3Aendern(BildDrehen.Winkel winkel)
    {
        _refresh3 = true;
        _winkel3 = winkel;
    }
    public void Winkel4Aendern(BildDrehen.Winkel winkel)
    {
        _refresh4 = true;
        _winkel4 = winkel;
    }
    public void Winkel5Aendern(BildDrehen.Winkel winkel)
    {
        _refresh5 = true;
        _winkel5 = winkel;
    }
    public void Winkel6Aendern(BildDrehen.Winkel winkel)
    {
        _refresh6 = true;
        _winkel6 = winkel;
    }
}
