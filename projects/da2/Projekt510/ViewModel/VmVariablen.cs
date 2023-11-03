using CommunityToolkit.Mvvm.ComponentModel;

namespace Projekt510.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private string _stringDezimaleZahl;
    [ObservableProperty] private string _stringBinaerC;
    [ObservableProperty] private string _stringBinaerPlc;
    [ObservableProperty] private string _stringHexadezimalC;
    [ObservableProperty] private string _stringHexadezimalPlc;
}
