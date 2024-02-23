using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Media;

namespace Projekt2005.ViewModel;

public partial class ViewModel : ObservableObject
{

    private readonly Model.Model _model;
    private readonly CancellationTokenSource _cancellationTokenSource;

    public ViewModel(Model.Model model, CancellationTokenSource cancellationTokenSource)
    {
        _model = model;
        _cancellationTokenSource = cancellationTokenSource;

        Brush00 = Brushes.LightGray;
        Brush01 = Brushes.LightGray;
        Brush02 = Brushes.LightGray;
        Brush03 = Brushes.LightGray;
        Brush10 = Brushes.LightGray;
        Brush11 = Brushes.LightGray;
        Brush12 = Brushes.LightGray;
        Brush13 = Brushes.LightGray;
        Brush20 = Brushes.LightGray;
        Brush21 = Brushes.LightGray;
        Brush22 = Brushes.LightGray;
        Brush23 = Brushes.LightGray;
        Brush30 = Brushes.LightGray;
        Brush31 = Brushes.LightGray;
        Brush32 = Brushes.LightGray;
        Brush33 = Brushes.LightGray;

        String00 = "1";
        String01 = "2";
        String02 = "4";
        String03 = "8";
        String10 = "16";
        String11 = "32";
        String12 = "64";
        String13 = "128";
        String20 = "256";
        String21 = "512";
        String22 = "1024";
        String23 = "2048";
        String30 = "";
        String31 = "";
        String32 = "";
        String33 = "";

        _ = Task.Run(VmTask);
    }
    private void VmTask()
    {
        while (!_cancellationTokenSource.IsCancellationRequested)
        {
            (String00, Brush00) = SpielfeldAnzeigen(0, 0);
            (String10, Brush10) = SpielfeldAnzeigen(1, 0);
            (String20, Brush20) = SpielfeldAnzeigen(2, 0);
            (String30, Brush30) = SpielfeldAnzeigen(3, 0);

            (String01, Brush01) = SpielfeldAnzeigen(0, 1);
            (String11, Brush11) = SpielfeldAnzeigen(1, 1);
            (String21, Brush21) = SpielfeldAnzeigen(2, 1);
            (String31, Brush31) = SpielfeldAnzeigen(3, 1);

            (String02, Brush02) = SpielfeldAnzeigen(0, 2);
            (String12, Brush12) = SpielfeldAnzeigen(1, 2);
            (String22, Brush22) = SpielfeldAnzeigen(2, 2);
            (String32, Brush32) = SpielfeldAnzeigen(3, 2);

            (String03, Brush03) = SpielfeldAnzeigen(0, 3);
            (String13, Brush13) = SpielfeldAnzeigen(1, 3);
            (String23, Brush23) = SpielfeldAnzeigen(2, 3);
            (String33, Brush33) = SpielfeldAnzeigen(3, 3);

            Thread.Sleep(50);
        }
    }

    private (string zahl, SolidColorBrush brushes) SpielfeldAnzeigen(int x, int y)
    {
        _ = x;
        _ = y;

        return ("0", Brushes.Aqua);
    }
}
