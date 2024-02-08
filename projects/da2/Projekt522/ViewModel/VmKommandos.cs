using CommunityToolkit.Mvvm.Input;

namespace Projekt522.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void ButtonTaster(string? taster)
        // ReSharper disable once ArrangeMethodOrOperatorBody
    {
        _ = taster;
    }
}
