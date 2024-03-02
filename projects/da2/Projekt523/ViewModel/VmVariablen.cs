using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace Projekt523.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private ObservableCollection<ComboBoxItem> _itemsListAvg;
    [ObservableProperty] private ObservableCollection<ComboBoxItem> _itemsListNum;
    [ObservableProperty] private ObservableCollection<ComboBoxItem> _itemsListBeschleunigung;

    [ObservableProperty] private Brush? _brushBeschleunigung;
    [ObservableProperty] private Brush? _brushHoehe;
    [ObservableProperty] private Brush? _brushGeschwindigkeit;
    [ObservableProperty] private Brush? _brushZeitachse;

    [ObservableProperty] private string? _stringGpsTrackName;

    [ObservableProperty] private Visibility _visibilityMittelwert;
    [ObservableProperty] private Visibility _visibilityBeschleunigung;


}
