using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Projekt2002.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private ObservableCollection<ComboBoxItem> _itemsList;

    [ObservableProperty] private Visibility _visibility00;
    [ObservableProperty] private Visibility _visibility01;
    [ObservableProperty] private Visibility _visibility02;
    [ObservableProperty] private Visibility _visibility03;

    [ObservableProperty] private Visibility _visibility10;
    [ObservableProperty] private Visibility _visibility11;
    [ObservableProperty] private Visibility _visibility12;
    [ObservableProperty] private Visibility _visibility13;

    [ObservableProperty] private Visibility _visibility20;
    [ObservableProperty] private Visibility _visibility21;
    [ObservableProperty] private Visibility _visibility22;
    [ObservableProperty] private Visibility _visibility23;

    [ObservableProperty] private Visibility _visibility30;
    [ObservableProperty] private Visibility _visibility31;
    [ObservableProperty] private Visibility _visibility32;
    [ObservableProperty] private Visibility _visibility33;


    [ObservableProperty] private string? _string00;
    [ObservableProperty] private string? _string01;
    [ObservableProperty] private string? _string02;
    [ObservableProperty] private string? _string03;

    [ObservableProperty] private string? _string10;
    [ObservableProperty] private string? _string11;
    [ObservableProperty] private string? _string12;
    [ObservableProperty] private string? _string13;

    [ObservableProperty] private string? _string20;
    [ObservableProperty] private string? _string21;
    [ObservableProperty] private string? _string22;
    [ObservableProperty] private string? _string23;

    [ObservableProperty] private string? _string30;
    [ObservableProperty] private string? _string31;
    [ObservableProperty] private string? _string32;
    [ObservableProperty] private string? _string33;

}
