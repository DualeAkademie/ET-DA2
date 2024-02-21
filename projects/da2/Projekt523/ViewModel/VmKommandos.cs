using CommunityToolkit.Mvvm.Input;

namespace Projekt523.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void ButtonTaster(string? taster)
    {
        if (taster == null) { return; }

        switch (taster)
        {
            case "file": _modelGps.GpxDateiOeffnen(); break;
            case "hoehe": _modelGps.HoehenprofilAnzeigen(); break;
            case "geschwindigkeit": _modelGps.GeschwindigkeitAnzeigen(); break;
        }
    }
}
