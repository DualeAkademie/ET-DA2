using CommunityToolkit.Mvvm.Input;

namespace Projekt2004.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void Button(string? feld)
    {
        switch (feld)
        {
            case null: return;
            case "Reset": _model.Reset(); break;
        }
    }
}
