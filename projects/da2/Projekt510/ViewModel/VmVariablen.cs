using CommunityToolkit.Mvvm.ComponentModel;

namespace Projekt510.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private string _stringDezimaleZahl;
    [ObservableProperty] private string _stringBinaer;
    [ObservableProperty] private string _stringHexadezimalPlc;
    [ObservableProperty] private string _stringHexadezimalC;
}
