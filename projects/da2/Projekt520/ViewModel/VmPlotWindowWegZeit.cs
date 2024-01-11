using ScottPlot;
using System.Windows;

namespace Projekt520.ViewModel;
public partial class ViewModel
{
    private void UpdatePlotWindowWegZeit()
    {
   

        if (_mainWindow.WpfPlotWegZeit == null) { return; }

        Application.Current.Dispatcher.Invoke(_mainWindow.WpfPlotWegZeit.Reset);

      

        Application.Current.Dispatcher.Invoke(() =>
        {
            var legend = _mainWindow.WpfPlotWegZeit.Plot.Legend();
            legend.Location = Alignment.UpperCenter;

            _mainWindow.WpfPlotWegZeit.Refresh();
        });
    }

    private void CrosshairZeichnenWegZeit(string? name)
    {
        if (_bildfahrplan == null || name == null) { return; }

        var pos = _bildfahrplan.PosBestimmen(name);
        var ch = _mainWindow.WpfPlotWegZeit.Plot.AddCrosshair(pos, 0);
        ch.HorizontalLine.LineWidth = 0;
        ch.VerticalLine.LineWidth = 2;

        _ = _mainWindow.WpfPlotWegZeit.Plot.AddText(name, pos, 0);
    }

    private void BahntrasseZeichnen(bool boolTrasse, double[]? fahrzeiten, double[]? trasse, string legende, LineStyle lineStyle)
    {
        if (!boolTrasse) { return; }

        var line = _mainWindow.WpfPlotWegZeit.Plot.AddScatter(trasse, fahrzeiten);
        line.Label = legende;
        line.LineStyle = lineStyle;
    }
}
