using CommunityToolkit.Mvvm.Input;

namespace Projekt1000.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void ButtonTaster(string? taster)
    {
        if (taster == "Save") { _mainWindow.DbContext.AenderungenSpeichern(); }
    }
}
