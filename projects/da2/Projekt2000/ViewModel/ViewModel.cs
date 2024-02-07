using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Media;

namespace Projekt2000.ViewModel;

public partial class ViewModel : ObservableObject
{
    private readonly MainWindow _mainWindow;
    // ReSharper disable once NotAccessedField.Local
    private readonly Model.Model _model;


    public ViewModel(MainWindow mainWindow, Model.Model model, CancellationTokenSource cancellationTokenSource)
    {
        _mainWindow = mainWindow;
        _model = model;


        Brush00 = Brushes.LightGray;
        Brush01 = Brushes.LightGray;
        Brush02 = Brushes.LightGray;
        Brush10 = Brushes.LightGray;
        Brush11 = Brushes.LightGray;
        Brush12 = Brushes.LightGray;
        Brush20 = Brushes.LightGray;
        Brush21 = Brushes.LightGray;
        Brush22 = Brushes.LightGray;

        String00 = " ";
        String01 = " ";
        String02 = " ";
        String10 = " ";
        String11 = " ";
        String12 = " ";
        String20 = " ";
        String21 = " ";
        String22 = " ";

        _ = Task.Run(() => VmTask(cancellationTokenSource.Token));
    }
    private void VmTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {

            _mainWindow.Dispatcher.Invoke(() =>
            {
              //
            });

            Thread.Sleep(100);
        }
    }
}
