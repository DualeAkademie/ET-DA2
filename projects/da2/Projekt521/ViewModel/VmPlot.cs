using ScottPlot;
using System.Windows;

namespace Projekt521.ViewModel;
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local
public partial class ViewModel
{
    private void PlotKennlinienAktualisieren()
    {
        if (_mainWindow.WpfPlotKennlinie?.Plot == null) { return; }

        Application.Current.Dispatcher.Invoke(() =>
        {
            _ = _mainWindow.WpfPlotKennlinie.Reset();
            var plt = _mainWindow.WpfPlotKennlinie.Plot;
            KurveAnzeigenKennlinien(plt, BoolPv, DoubleEnergiePv, s_farbePv, "PV");
            KurveAnzeigenKennlinien(plt, BoolWp, DoubleEnergieWp, s_farbeWp, "WP");
            KurveAnzeigenKennlinien(plt, BoolH0, DoubleEnergieH0, s_farbeH0, "H0");
            KurveAnzeigenKennlinien(plt, BoolG0, DoubleEnergieG0, s_farbeG0, "G0");
            KurveAnzeigenKennlinien(plt, BoolG1, DoubleEnergieG1, s_farbeG1, "G1");
            KurveAnzeigenKennlinien(plt, BoolG2, DoubleEnergieG2, s_farbeG2, "G2");
            KurveAnzeigenKennlinien(plt, BoolG3, DoubleEnergieG3, s_farbeG3, "G3");
            KurveAnzeigenKennlinien(plt, BoolG4, DoubleEnergieG4, s_farbeG4, "G4");
            KurveAnzeigenKennlinien(plt, BoolG5, DoubleEnergieG5, s_farbeG5, "G5");
            KurveAnzeigenKennlinien(plt, BoolG6, DoubleEnergieG6, s_farbeG6, "G6");
            KurveAnzeigenKennlinien(plt, BoolL0, DoubleEnergieL0, s_farbeL0, "L0");
            KurveAnzeigenKennlinien(plt, BoolL1, DoubleEnergieL1, s_farbeL1, "L1");
            KurveAnzeigenKennlinien(plt, BoolL2, DoubleEnergieL2, s_farbeL2, "L2");

            plt.Legend.Location = Alignment.UpperLeft;
            plt.Axes.DateTimeTicks(Edge.Bottom);

            _mainWindow.WpfPlotKennlinie.Refresh();
        });
    }
    private void PlotWpAkkuAktualisieren()
    {
        if (_mainWindow.WpfPlotAkku?.Plot == null) { return; }

        Application.Current.Dispatcher.Invoke(() =>
          {
              _ = _mainWindow.WpfPlotAkku.Reset();
            
              _mainWindow.WpfPlotAkku.Refresh();
          });
    }
    private void PlotPvWpAktualisieren()
    {
        if (_mainWindow.WpfPlotPvWp?.Plot == null) { return; }

        Application.Current.Dispatcher.Invoke(() =>
        {
            _ = _mainWindow.WpfPlotPvWp.Reset();
          

            _mainWindow.WpfPlotPvWp.Refresh();
        });
    }
 
    private void KurveAnzeigenKennlinien(Plot plot, bool anzeigen, double[]? doubleLeistung, Color solidColor, string label)
    {
     _ = anzeigen;
     _ = doubleLeistung;
     _ = solidColor;
     _ = label;
     _= plot;
    }
}
