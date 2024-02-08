using CommunityToolkit.Mvvm.Input;

namespace Projekt521.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void ButtonTaster(string? taster)
    {
     _ = taster;

        UpdatePlotWindowKennlinie(_mainWindow.TabBez, taster, true, "-");
    }
}
