using CommunityToolkit.Mvvm.Input;

namespace Projekt521.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void ButtonTaster(string? taster)
    {
        switch (taster)
        {
            case "Pv": BoolPv = !BoolPv; break;
            case "Wp": BoolWp = !BoolWp; break;
            case "H0": BoolH0 = !BoolH0; break;
            case "G0": BoolG0 = !BoolG0; break;
            case "G1": BoolG1 = !BoolG1; break;
            case "G2": BoolG2 = !BoolG2; break;
            case "G3": BoolG3 = !BoolG3; break;
            case "G4": BoolG4 = !BoolG4; break;
            case "G5": BoolG5 = !BoolG5; break;
            case "G6": BoolG6 = !BoolG6; break;
            case "L0": BoolL0 = !BoolL0; break;
            case "L1": BoolL1 = !BoolL1; break;
            case "L2": BoolL2 = !BoolL2; break;
            case "WpVonPv": BoolWpVonPv = !BoolWpVonPv; break;
            case "WpVomNetz": BoolWpVomNetz = !BoolWpVomNetz; break;
            case "WpVonPv+Akku": BoolWpVonPvAkku = !BoolWpVonPvAkku; break;
            case "PvUeberschuss": BoolPvUeberschuss = !BoolPvUeberschuss; break;
            case "Akku": BoolAkku = !BoolAkku; break;
        }

        UpdatePlotWindowKennlinie(_mainWindow.TabBez, taster, true, "-");
    }
}
