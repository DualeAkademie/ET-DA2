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

    private bool _refreshArray3;
    private bool _refreshArray4;
    private bool _refreshArray5;
    private bool _refreshArray6;

    public ViewModel(CancellationTokenSource cancellationTokenSource)
    {
        InitializeArray3();
        InitializeArray4();
        InitializeArray5();
        InitializeArray6();

        _ = Task.Run(() => ViewModelTask(cancellationTokenSource.Token));
    }

    private void ViewModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            RefreshArray3();
            RefreshArray4();
            RefreshArray5();
            RefreshArray6();

            Thread.Sleep(100);
        }
    }
}
