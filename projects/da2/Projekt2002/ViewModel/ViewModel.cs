using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Projekt2002.ViewModel;

public partial class ViewModel : ObservableObject
{
    private readonly Model.Model _model;
    private readonly CancellationTokenSource _cancellationTokenSource;


    public ViewModel(Model.Model model, CancellationTokenSource cancellationTokenSource)
    {
        _model = model;
        _cancellationTokenSource = cancellationTokenSource;

        ItemsList =
        [
            new ComboBoxItem() ,

            new ComboBoxItem { Content = "1", Tag = 1, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "2", Tag = 2, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "5", Tag = 5, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "10", Tag = 10, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "20", Tag = 20, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "100", Tag = 100, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "200", Tag = 200, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center },
            new ComboBoxItem { Content = "1000", Tag = 1000, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center },
            new ComboBoxItem { Content = "2000", Tag = 2000, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center }

        ];

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
            (Visibility00, String00) = Spielsteinlesen(0, 0);
            (Visibility01, String01) = Spielsteinlesen(0, 1);
            (Visibility02, String02) = Spielsteinlesen(0, 2);
            (Visibility03, String03) = Spielsteinlesen(0, 3);

            (Visibility10, String10) = Spielsteinlesen(1, 0);
            (Visibility11, String11) = Spielsteinlesen(1, 1);
            (Visibility12, String12) = Spielsteinlesen(1, 2);
            (Visibility13, String13) = Spielsteinlesen(1, 3);

            (Visibility20, String20) = Spielsteinlesen(2, 0);
            (Visibility21, String21) = Spielsteinlesen(2, 1);
            (Visibility22, String22) = Spielsteinlesen(2, 2);
            (Visibility23, String23) = Spielsteinlesen(2, 3);

            (Visibility30, String30) = Spielsteinlesen(3, 0);
            (Visibility31, String31) = Spielsteinlesen(3, 1);
            (Visibility32, String32) = Spielsteinlesen(3, 2);
            (Visibility33, String33) = Spielsteinlesen(3, 3);


            Thread.Sleep(50);
        }
    }

    private (Visibility vis, string? str) Spielsteinlesen(int x, int y)
    {
        _ = x;
        _ = y;
        return (Visibility.Visible, "1");
    }
}
