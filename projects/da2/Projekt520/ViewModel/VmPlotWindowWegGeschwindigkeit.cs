using ScottPlot;
using System.Drawing;
using System.Windows;

namespace Projekt520.ViewModel;

public partial class ViewModel
{
    private void UpdatePlotWindowWegGeschwindigkeit() =>
        Application.Current.Dispatcher.Invoke(() =>
        {
            var legend = _mainWindow.WpfPlotWegGeschwindigkeit.Plot.Legend();
            legend.Location = Alignment.UpperCenter;

            _mainWindow.WpfPlotWegGeschwindigkeit.Refresh();
        });

    private void GeschwindigkeitZeichnen(bool boolTrasse, IReadOnlyList<double>? geschwindigkeit, IReadOnlyList<double>? trasse, Color color, Color colorBorder)
    {
        if (!boolTrasse) { return; }
        if (geschwindigkeit == null || trasse == null) { return; }

        var anzahlDatenpunkte = trasse.Count / 2;

        for (var i = 0; i < anzahlDatenpunkte - 1; i++)
        {
            var rectangle = _mainWindow.WpfPlotWegGeschwindigkeit.Plot.AddRectangle(trasse[1 + 2 * i], trasse[2 + 2 * i], 0, geschwindigkeit[2 + 2 * i]);
            rectangle.BorderColor = colorBorder;
            rectangle.BorderLineWidth = 3;
            rectangle.Color = color;
        }
    }

    private void CrosshairZeichnenWegGeschwindigkeit(string? name)
    {
        if (_bildfahrplan == null || name == null) { return; }

        var pos = _bildfahrplan.PosBestimmen(name);
        var ch = _mainWindow.WpfPlotWegGeschwindigkeit.Plot.AddCrosshair(pos, 0);
        ch.HorizontalLine.LineWidth = 0;
        ch.VerticalLine.LineWidth = 2;

        _ = _mainWindow.WpfPlotWegGeschwindigkeit.Plot.AddText(name, pos, 0);
    }
}
