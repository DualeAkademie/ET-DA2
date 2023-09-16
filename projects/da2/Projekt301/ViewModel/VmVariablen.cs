using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Controls;

namespace Projekt301.ViewModel;

public partial class VmProjekt
{
    [ObservableProperty] private ClickMode _clickModePlus;
    [ObservableProperty] private ClickMode _clickModeMinus;

    [ObservableProperty] private string _stringText;
}
