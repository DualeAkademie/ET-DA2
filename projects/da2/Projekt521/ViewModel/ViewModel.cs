using CommunityToolkit.Mvvm.ComponentModel;
using Projekt521.Model;
using System.Windows;
using System.Windows.Media;

namespace Projekt521.ViewModel;

public partial class ViewModel : ObservableObject
{
    private const int EinJahr = 365 * 24 * 4;
    private readonly AlleDaten _alleDaten;
    private readonly MainWindow _mainWindow;

    private DateTime _dtStartAlt;
    private DateTime _dtEndAlt;
    private MainWindow.TabBezeichnung _tabBezeichnungAlt = MainWindow.TabBezeichnung.None;
    private string? _tasterAlt;

    private static readonly SolidColorBrush s_farbeH0 = Brushes.SeaGreen;
    private static readonly SolidColorBrush s_farbeG0 = Brushes.LawnGreen;
    private static readonly SolidColorBrush s_farbeG1 = Brushes.LawnGreen;
    private static readonly SolidColorBrush s_farbeG2 = Brushes.LawnGreen;
    private static readonly SolidColorBrush s_farbeG3 = Brushes.LawnGreen;
    private static readonly SolidColorBrush s_farbeG4 = Brushes.LawnGreen;
    private static readonly SolidColorBrush s_farbeG5 = Brushes.LawnGreen;
    private static readonly SolidColorBrush s_farbeG6 = Brushes.LawnGreen;
    private static readonly SolidColorBrush s_farbeL0 = Brushes.Olive;
    private static readonly SolidColorBrush s_farbeL1 = Brushes.Olive;
    private static readonly SolidColorBrush s_farbeL2 = Brushes.Olive;
    private static readonly SolidColorBrush s_farbePv = Brushes.Red;
    private static readonly SolidColorBrush s_farbeWp = Brushes.Cyan;

    private static readonly SolidColorBrush s_farbeWpVonPv = Brushes.HotPink;
    private static readonly SolidColorBrush s_farbeWpVonPvAkku = Brushes.Aqua;
    private static readonly SolidColorBrush s_farbeWpvomNetz = Brushes.MediumSlateBlue;
    private static readonly SolidColorBrush s_farbePvUeberschuss = Brushes.Crimson;
    private static readonly SolidColorBrush s_farbeEnergieAkku = Brushes.BlueViolet;
    private static readonly SolidColorBrush s_farbeEnergieflussAkku = Brushes.Violet;



    public ViewModel(CancellationTokenSource cancellationTokenSource, AlleDaten alleDaten, MainWindow mainWindow)
    {

        _alleDaten = alleDaten;
        _mainWindow = mainWindow;



        _ = Task.Run(() => ViewModelTask(cancellationTokenSource.Token));
    }

    private void ViewModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
           
            Thread.Sleep(100);
        }
    }
    private static (SolidColorBrush color, Visibility vis) ButtonFarbe(bool boolButton, SolidColorBrush farbeAktiv)
    {
        var color = boolButton ? farbeAktiv : Brushes.Gray;
        var vis = boolButton ? Visibility.Visible : Visibility.Collapsed;

        return (color, vis);
    }
    private string MaximalleistungBerechnen(int jahresenergie, AlleDaten.LeistungsProfile profil) => $"{4 * jahresenergie / _alleDaten.GesamtenergieVdew[(int) profil] * _alleDaten.MaximalLeistungVdew[(int) profil]:f2}";
}
