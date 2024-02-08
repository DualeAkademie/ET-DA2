using ScottPlot;

namespace Projekt520.ViewModel;

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local
public partial class ViewModel
{
    private void UpdatePlotWindowWegGeschwindigkeit()
    {
        if (_mainWindow.WpfPlotWegGeschwindigkeit?.Plot == null) { return; }

     
    }
    private static void GeschwindigkeitZeichnen(Plot plot, bool boolTrasse, IReadOnlyList<double>? geschwindigkeit, IReadOnlyList<double>? trasse, Color color, Color colorBorder)
    {
        if (!boolTrasse) { return; }
        if (geschwindigkeit == null || trasse == null) { return; }

        var anzahlDatenpunkte = trasse.Count / 2;

        for (var i = 0; i < anzahlDatenpunkte - 1; i++)
        {
            var rectangle = plot.Add.Rectangle(trasse[1 + 2 * i], trasse[2 + 2 * i], 0, geschwindigkeit[2 + 2 * i]);
            rectangle.LineStyle.Color = colorBorder;
            rectangle.LineStyle.Width = 3;
            rectangle.FillStyle.Color = color;
        }
    }
}
