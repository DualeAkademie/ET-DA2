using CommunityToolkit.Mvvm.Input;

namespace Projekt2002.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void Button(string? feld) => _model.MouseClick(feld);

    [RelayCommand]
    private void Reset() => _model.PuzzleDurchmischen();
}
