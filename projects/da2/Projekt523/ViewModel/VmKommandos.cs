using CommunityToolkit.Mvvm.Input;

namespace Projekt523.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void ButtonTaster(string? taster)
    {
        if (taster is null) { return; }

        switch (taster)
        {
            case "file":
                _modelGps.GpxDateiOeffnen();
                _hoeheAnzeigen = false;
                _geschwindigkeitAnzeigen = true;
                break;

            case "beschleunigung": _beschleunigungAnzeigen = !_beschleunigungAnzeigen; break;
            case "hoehe": _hoeheAnzeigen = !_hoeheAnzeigen; break;
            case "geschwindigkeit": _geschwindigkeitAnzeigen = !_geschwindigkeitAnzeigen; break;
            case "zeit": _zeitachseAnzeigen = !_zeitachseAnzeigen; break;
        }

        PlotAnzeigen();
    }
}
