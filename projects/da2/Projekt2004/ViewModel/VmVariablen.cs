using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace Projekt2004.ViewModel;

public partial class ViewModel
{

    [ObservableProperty] private string _stringErgebnis;
    [ObservableProperty] private string _stringFehlermeldung;

    [ObservableProperty] private Visibility _visibilityFehlermeldung;
}
