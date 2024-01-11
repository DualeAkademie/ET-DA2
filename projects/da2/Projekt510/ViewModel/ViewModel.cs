using CommunityToolkit.Mvvm.ComponentModel;
using Projekt510.Model;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Projekt510.ViewModel;

public partial class ViewModel : ObservableObject
{
    public ObservableCollection<HornerSchema> HornerSchemaBin { get; set; }
    public ObservableCollection<HornerSchema> HornerSchemaHex { get; set; }

    public int AnzahlByte { get; set; }
    private readonly MainWindow _mainWindow;

    public ViewModel(MainWindow mainWindow, CancellationTokenSource cancellationTokenSource)
    {
        _mainWindow = mainWindow;

        HornerSchemaBin = [];
        HornerSchemaHex = [];

        StringDezimaleZahl = "";
        StringBinaerC = "";
        StringBinaerPlc = "";
        StringHexadezimalC = "";
        StringHexadezimalPlc = "";

        _ = Task.Run(() => ViewModelTask(cancellationTokenSource.Token));
    }

    private void ViewModelTask(CancellationToken cancellationToken)
    {
        bool breiteBin = false;
        bool breiteHex = false;

        while (!cancellationToken.IsCancellationRequested)
        {
            if (!breiteBin && !breiteHex)
            {
                Application.Current.Dispatcher.Invoke(() =>
                          {
                              if (_mainWindow.DataGridHornerBin is { Columns.Count: > 0 })
                              {
                                  _mainWindow.DataGridHornerBin.Columns[0].MinWidth = 170;
                                  _mainWindow.DataGridHornerBin.Columns[1].MinWidth = 170;
                                  _mainWindow.DataGridHornerBin.Columns[2].MinWidth = 55;
                                  breiteBin = true;
                              }

                              if (_mainWindow.DataGridHornerHex is not { Columns.Count: > 0 })
                              {
                                  return;
                              }

                              _mainWindow.DataGridHornerHex.Columns[0].MinWidth = 170;
                              _mainWindow.DataGridHornerHex.Columns[1].MinWidth = 170;
                              _mainWindow.DataGridHornerHex.Columns[2].MinWidth = 55;
                              breiteHex = true;
                          });
            }
        }
    }
}
