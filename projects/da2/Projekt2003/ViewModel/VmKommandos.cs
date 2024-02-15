using CommunityToolkit.Mvvm.Input;

namespace Projekt2003.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void Button(string? feld)
    {
        if (feld is null) { return; }
        _model.MouseClick(feld);
    }

    [RelayCommand]
    private void Reset(string? feld)
    {
        if (feld is null) { return; }

        switch (feld)
        {
            case "NeuesBild": _model.SetNeuesBild(); break;
            case "Mischen": _model.PuzzleMischen(); break;
        }
    }
}
