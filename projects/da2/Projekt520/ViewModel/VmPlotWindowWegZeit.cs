using ScottPlot;
using System.Windows;

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

namespace Projekt520.ViewModel;
public partial class ViewModel
{
    private void UpdatePlotWindowWegZeit()
    {
        if (_mainWindow.WpfPlotWegZeit?.Plot == null) { return; }

        _ = Application.Current.Dispatcher.Invoke(_mainWindow.WpfPlotWegZeit.Reset);
        var plot = _mainWindow.WpfPlotWegZeit.Plot;

        Application.Current.Dispatcher.Invoke(() =>
       {
           plot.Legend.Location = Alignment.UpperCenter;
           _mainWindow.WpfPlotWegZeit.Refresh();
       });
    }
    private static void BahntrasseZeichnen(Plot plot, bool boolTrasse, double[]? fahrzeiten, double[]? trasse, string legende, bool linieDurchgezogen)
    {
        if (!boolTrasse) { return; }
        if (fahrzeiten == null || trasse == null) { return; }

        LinePattern[] patterns = Enum.GetValues<LinePattern>();

        var line = plot.Add.Scatter(trasse, fahrzeiten);
        line.Label = legende;
        line.LineStyle.Pattern = linieDurchgezogen ? patterns[0] : patterns[1];
    }
}
