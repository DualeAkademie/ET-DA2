using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace Projekt2002.ViewModel;

public partial class ViewModel : ObservableObject
{
    // ReSharper disable once NotAccessedField.Local
    private readonly Model.Model _model;
    private readonly CancellationTokenSource _cancellationTokenSource;


    public ViewModel(Model.Model model, CancellationTokenSource cancellationTokenSource)
    {
        _model = model;
        _cancellationTokenSource = cancellationTokenSource;

        Visibility00 = Visibility.Visible;
        Visibility01 = Visibility.Visible;
        Visibility02 = Visibility.Visible;
        Visibility03 = Visibility.Visible;

        Visibility10 = Visibility.Visible;
        Visibility11 = Visibility.Visible;
        Visibility12 = Visibility.Visible;
        Visibility13 = Visibility.Visible;

        Visibility20 = Visibility.Visible;
        Visibility21 = Visibility.Visible;
        Visibility22 = Visibility.Visible;
        Visibility23 = Visibility.Visible;

        Visibility30 = Visibility.Visible;
        Visibility31 = Visibility.Visible;
        Visibility32 = Visibility.Visible;
        Visibility33 = Visibility.Visible;


        String00 = "1";
        String01 = "2";
        String02 = "3";
        String03 = "4";

        String10 = "5";
        String11 = "6";
        String12 = "7";
        String13 = "8";

        String20 = "9";
        String21 = "10";
        String22 = "11";
        String23 = "12";

        String30 = "13";
        String31 = "14";
        String32 = "15";
        String33 = "16";

        _ = Task.Run(VmTask);
    }
    private void VmTask()
    {
        while (!_cancellationTokenSource.IsCancellationRequested)
        {

            Thread.Sleep(50);
        }
    }
}
