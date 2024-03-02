using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ArrangeMethodOrOperatorBody
// ReSharper disable UnusedVariable

namespace Projekt523.ViewModel;

public partial class ViewModel : ObservableObject
{
    private readonly MainWindow _mainWindow;
    private readonly Model.Model _modelGps;

    private bool _beschleunigungAnzeigen;
    private bool _hoeheAnzeigen;
    private bool _geschwindigkeitAnzeigen;
    private bool _zeitachseAnzeigen;

    public ViewModel(CancellationTokenSource cancellationTokenSource, MainWindow mainWindow, Model.Model modelGps)
    {
        _mainWindow = mainWindow;
        _modelGps = modelGps;

        BrushBeschleunigung = Brushes.LightGray;
        BrushGeschwindigkeit = Brushes.LightGray;
        BrushHoehe = Brushes.LightGray;
        BrushZeitachse = Brushes.LightGray;

        ItemsListAvg =
        [
            new ComboBoxItem { Content = "kein Mittelwert",          Tag = 1, HorizontalContentAlignment = HorizontalAlignment.Left, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "CumulativeMovingAverage",  Tag = 2, HorizontalContentAlignment = HorizontalAlignment.Left, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "SimpleMovingAverage",      Tag = 3, HorizontalContentAlignment = HorizontalAlignment.Left, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "ExponentialMovingAverage", Tag = 4, HorizontalContentAlignment = HorizontalAlignment.Left, VerticalContentAlignment = VerticalAlignment.Center}
        ];

        ItemsListNum =
        [
            new ComboBoxItem { Content = "0",  Tag = 0,  HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "1",  Tag = 1,  HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "2",  Tag = 2,  HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "3",  Tag = 3,  HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "5",  Tag = 5,  HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "10", Tag = 10, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "15", Tag = 15, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "20", Tag = 20, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "30", Tag = 30, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "50", Tag = 50, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center}
        ];

        ItemsListBeschleunigung =
        [
            new ComboBoxItem { Content = "1", Tag = 1, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "2", Tag = 2, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "3", Tag = 3, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "4", Tag = 4, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "5", Tag = 5, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center}
        ];

        _ = Task.Run(() => ViewModelTask(cancellationTokenSource.Token));
    }
    private void ViewModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            Thread.Sleep(100);
        }
    }
    private void PlotAnzeigen()
    {
        //

        Application.Current.Dispatcher.Invoke(() =>
                {
                    _ = _mainWindow.WpfPlot.Reset();
                    var plt = _mainWindow.WpfPlot.Plot;


                    _mainWindow.WpfPlot.Refresh();
                });
    }

    public void MittelwertUpdaten() => PlotAnzeigen();
}
