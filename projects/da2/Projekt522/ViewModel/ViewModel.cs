using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Media;
#pragma warning disable CS0169 // Field is never used

namespace Projekt522.ViewModel;

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local
public partial class ViewModel : ObservableObject
{
    private readonly MainWindow _mainWindow;
    private List<(char zeichen, string morsecode)>? _morseCodeListe;
    private readonly Brush _farbeLampeEin = Brushes.YellowGreen;
    private readonly Brush _farbeLampeAus = Brushes.LightGray;

    public ViewModel(CancellationTokenSource cancellationTokenSource, MainWindow mainWindow)
    {
        _mainWindow = mainWindow;

        BrushLampe = _farbeLampeAus;

        IntGeschwindigkeit = 2;
        StringAktuellesZeichen = "";
        StringEingabe = "Hallo Welt";

        _ = Task.Run(() => ViewModelTask(cancellationTokenSource.Token));
    }

    private void ViewModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            if (_mainWindow.TextBlockMorseCode == null){continue;}

            _mainWindow.Dispatcher.Invoke(_mainWindow.TextBlockMorseCode.Inlines.Clear);
        }

        Thread.Sleep(100);
    }
}
