using CommunityToolkit.Mvvm.ComponentModel;

namespace Projekt1000.ViewModel;

public partial class ViewModel : ObservableObject
{
    private readonly MainWindow _mainWindow;

    public ViewModel(MainWindow mainWindow)
    {
        _mainWindow = mainWindow;

        Categories = [];
        Products = [];
        Uebersicht = [];
    }
}
