using ScottPlot;
using System.Windows;
using System.Windows.Media;

namespace Projekt521.ViewModel;

public partial class ViewModel
{
    private void PlotKennlinienAktualisieren()
    {
        Application.Current.Dispatcher.Invoke(_mainWindow.WpfPlotKennlinie.Reset);

      
        Application.Current.Dispatcher.Invoke(() =>
        {
            var legend = _mainWindow.WpfPlotKennlinie.Plot.Legend();
            legend.Location = Alignment.UpperLeft;

            _mainWindow.WpfPlotKennlinie.Plot.XAxis.DateTimeFormat(true);
            _mainWindow.WpfPlotKennlinie.Refresh();
        });
    }
    private void PlotWpAkkuAktualisieren()
    {
        Application.Current.Dispatcher.Invoke(_mainWindow.WpfPlotAkku.Reset);

        Application.Current.Dispatcher.Invoke(() =>
        {
            var legend = _mainWindow.WpfPlotAkku.Plot.Legend();
            legend.Location = Alignment.UpperLeft;

            _mainWindow.WpfPlotAkku.Plot.XAxis.DateTimeFormat(true);
            _mainWindow.WpfPlotAkku.Refresh();
        });
    }
    private void PlotPvWpAktualisieren()
    {
        Application.Current.Dispatcher.Invoke(_mainWindow.WpfPlotPvWp.Reset);

      
        Application.Current.Dispatcher.Invoke(() =>
        {
            var legend = _mainWindow.WpfPlotPvWp.Plot.Legend();
            legend.Location = Alignment.UpperLeft;

            _mainWindow.WpfPlotPvWp.Plot.XAxis.DateTimeFormat(true);
            _mainWindow.WpfPlotPvWp.Refresh();
        });
    }
    private static System.Drawing.Color SolidColorBrushToDrawingColor(SolidColorBrush br) => System.Drawing.Color.FromArgb(br.Color.A, br.Color.R, br.Color.G, br.Color.B);
    private void KurveAnzeigenPvWp(bool anzeigen, double[]? doubleLeistung, float lineWidth, SolidColorBrush solidColor, string label)
    {
        if (!anzeigen) { return; }

        var line = _mainWindow.WpfPlotPvWp.Plot.AddScatter(DoubleZeitAchse, doubleLeistung);
        line.MarkerSize = lineWidth;
        line.Color = SolidColorBrushToDrawingColor(solidColor);
        line.MarkerSize = 0;
        line.Label = label;
    }
    private void KurveAnzeigenAkku(bool anzeigen, double[]? doubleLeistung, float lineWidth, SolidColorBrush solidColor, string label)
    {
        if (!anzeigen) { return; }

        var line = _mainWindow.WpfPlotAkku.Plot.AddScatter(DoubleZeitAchse, doubleLeistung);
        line.MarkerSize = lineWidth;
        line.Color = SolidColorBrushToDrawingColor(solidColor);
        line.MarkerSize = 0;
        line.Label = label;
    }
    private void KurveAnzeigenKennlinien(bool anzeigen, double[]? doubleLeistung, SolidColorBrush solidColor, string label)
    {
        if (!anzeigen) { return; }

        var line = _mainWindow.WpfPlotKennlinie.Plot.AddScatter(DoubleZeitAchse, doubleLeistung);
        line.Color = SolidColorBrushToDrawingColor(solidColor);
        line.MarkerSize = 0;
        line.Label = label;
    }
}
