using CommunityToolkit.Mvvm.ComponentModel;
using Projekt521.Model;
using System.Windows;
using System.Windows.Media;

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

namespace Projekt521.ViewModel;

public partial class ViewModel : ObservableObject
{
    private const int EinJahr = 365 * 24 * 4;
    private readonly AlleDaten _alleDaten;
    private readonly MainWindow _mainWindow;
    
    private static readonly ScottPlot.Color s_farbeH0 = ScottPlot.Colors.SeaGreen;
    private static readonly ScottPlot.Color s_farbeG0 = ScottPlot.Colors.LawnGreen;
    private static readonly ScottPlot.Color s_farbeG1 = ScottPlot.Colors.LawnGreen;
    private static readonly ScottPlot.Color s_farbeG2 = ScottPlot.Colors.LawnGreen;
    private static readonly ScottPlot.Color s_farbeG3 = ScottPlot.Colors.LawnGreen;
    private static readonly ScottPlot.Color s_farbeG4 = ScottPlot.Colors.LawnGreen;
    private static readonly ScottPlot.Color s_farbeG5 = ScottPlot.Colors.LawnGreen;
    private static readonly ScottPlot.Color s_farbeG6 = ScottPlot.Colors.LawnGreen;
    private static readonly ScottPlot.Color s_farbeL0 = ScottPlot.Colors.Olive;
    private static readonly ScottPlot.Color s_farbeL1 = ScottPlot.Colors.Olive;
    private static readonly ScottPlot.Color s_farbeL2 = ScottPlot.Colors.Olive;
    private static readonly ScottPlot.Color s_farbePv = ScottPlot.Colors.Red;
    private static readonly ScottPlot.Color s_farbeWp = ScottPlot.Colors.Cyan;

    private static readonly ScottPlot.Color s_farbeWpVonPv = ScottPlot.Colors.HotPink;
    private static readonly ScottPlot.Color s_farbeWpVonPvAkku = ScottPlot.Colors.Aqua;
    private static readonly ScottPlot.Color s_farbeWpvomNetz = ScottPlot.Colors.MediumSlateBlue;
    private static readonly ScottPlot.Color s_farbePvUeberschuss = ScottPlot.Colors.Crimson;
    private static readonly ScottPlot.Color s_farbeEnergieAkku = ScottPlot.Colors.BlueViolet;
    private static readonly ScottPlot.Color s_farbeEnergieflussAkku = ScottPlot.Colors.Violet;


    public ViewModel(CancellationTokenSource cancellationTokenSource, AlleDaten alleDaten, MainWindow mainWindow)
    {

        _alleDaten = alleDaten;
        _mainWindow = mainWindow;

        DateTimeStart = new DateTime(2022, 1, 1, 0, 0, 0);
        DateTimeEnd = new DateTime(2022, 12, 31, 0, 0, 0);

        StringTooltipAkku = "Akku";
        StringTooltipPv = $" {_alleDaten.PvDaten?.Kurzbezeichnung} / {_alleDaten.PvDaten?.Langbezeichnung}";
        StringTooltipWp = $" {_alleDaten.WpDaten?.Kurzbezeichnung} / {_alleDaten.WpDaten?.Langbezeichnung}";
        StringTooltipH0 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.H0].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.H0].Langbezeichnung}";
        StringTooltipG0 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G0].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G0].Langbezeichnung}";
        StringTooltipG1 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G1].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G1].Langbezeichnung}";
        StringTooltipG2 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G2].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G2].Langbezeichnung}";
        StringTooltipG3 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G3].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G3].Langbezeichnung}";
        StringTooltipG4 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G4].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G4].Langbezeichnung}";
        StringTooltipG5 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G5].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G5].Langbezeichnung}";
        StringTooltipG6 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G6].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.G6].Langbezeichnung}";
        StringTooltipL0 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.L0].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.L0].Langbezeichnung}";
        StringTooltipL1 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.L1].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.L1].Langbezeichnung}";
        StringTooltipL2 = $" {_alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.L1].Kurzbezeichnung} / {alleDaten.VdewLastprofile?.VdewProfile?[(int) AlleDaten.LeistungsProfile.L1].Langbezeichnung}";

        _ = Task.Run(() => ViewModelTask(cancellationTokenSource.Token));
    }

    private void ViewModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                (BrushWpvonPv, VisibilityWpvonPv) = ButtonFarbe(BoolWpVonPv, s_farbeWpVonPv);
                (BrushWpvonPvAkku, VisibilityWpvonPvAkku) = ButtonFarbe(BoolWpVonPvAkku, s_farbeWpVonPvAkku);
                (BrushWpvomNetz, VisibilityWpvomNetz) = ButtonFarbe(BoolWpVomNetz, s_farbeWpvomNetz);
                (BrushPvUeberschuss, VisibilityPvUeberschuss) = ButtonFarbe(BoolPvUeberschuss, s_farbePvUeberschuss);
                (BrushAkku, VisibilityAkku) = ButtonFarbe(BoolAkku, s_farbeEnergieAkku);
                (BrushPv, VisibilityJahresenergiePv) = ButtonFarbe(BoolPv, s_farbePv);
                (BrushWp, VisibilityJahresenergieWp) = ButtonFarbe(BoolWp, s_farbeWp);
                (BrushH0, VisibilityJahresenergieH0) = ButtonFarbe(BoolH0, s_farbeH0);
                (BrushG0, VisibilityJahresenergieG0) = ButtonFarbe(BoolG0, s_farbeG0);
                (BrushG1, VisibilityJahresenergieG1) = ButtonFarbe(BoolG1, s_farbeG1);
                (BrushG2, VisibilityJahresenergieG2) = ButtonFarbe(BoolG2, s_farbeG2);
                (BrushG3, VisibilityJahresenergieG3) = ButtonFarbe(BoolG3, s_farbeG3);
                (BrushG4, VisibilityJahresenergieG4) = ButtonFarbe(BoolG4, s_farbeG4);
                (BrushG5, VisibilityJahresenergieG5) = ButtonFarbe(BoolG5, s_farbeG5);
                (BrushG6, VisibilityJahresenergieG6) = ButtonFarbe(BoolG6, s_farbeG6);
                (BrushL0, VisibilityJahresenergieL0) = ButtonFarbe(BoolL0, s_farbeL0);
                (BrushL1, VisibilityJahresenergieL1) = ButtonFarbe(BoolL1, s_farbeL1);
                (BrushL2, VisibilityJahresenergieL2) = ButtonFarbe(BoolL2, s_farbeL2);
            });

            Thread.Sleep(100);
        }
    }
    private static (Brush color, Visibility vis) ButtonFarbe(bool boolButton, ScottPlot.Color farbeAktiv)
    {
        var aktiveFarbe = new SolidColorBrush(Color.FromArgb(farbeAktiv.A, farbeAktiv.R, farbeAktiv.G, farbeAktiv.B));
        var color = boolButton ? aktiveFarbe : Brushes.Gray;
        var vis = boolButton ? Visibility.Visible : Visibility.Collapsed;

        return (color, vis);
    }
    private string MaximalleistungBerechnen(int jahresenergie, AlleDaten.LeistungsProfile profil) => $"{4 * jahresenergie / _alleDaten.GesamtenergieVdew[(int) profil] * _alleDaten.MaximalLeistungVdew[(int) profil]:f2}";
}
