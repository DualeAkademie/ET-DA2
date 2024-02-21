using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Projekt2004.ViewModel;

public partial class ViewModel : ObservableObject
{
    private Canvas? _canvas;
    private readonly Model.Model _model;
    private readonly CancellationTokenSource _cancellationTokenSource;

    public ViewModel(Model.Model model, CancellationTokenSource cancellationTokenSource)
    {
        _model = model;
        _cancellationTokenSource = cancellationTokenSource;

        StringErgebnis = "";
        StringFehlermeldung = "Game over!";
        VisibilityFehlermeldung = Visibility.Collapsed;
        
        _ = Task.Run(VmTask);
    }
    private void VmTask()
    {
        while (!_cancellationTokenSource.IsCancellationRequested)
        {
            Thread.Sleep(50);

            if (_canvas == null) { continue; }

            Application.Current.Dispatcher.Invoke(() =>
            {
                _canvas.Children.Clear();
                _model.Futter.Zeichnen(_canvas);
                _model.Snake.Zeichnen(_canvas);
            });

            StringErgebnis = "Aktuelle Punkte: " + _model.AnzahlPunkte;
        }
    }
    internal void SetCanvas(Canvas canvas) => _canvas = canvas;
}
