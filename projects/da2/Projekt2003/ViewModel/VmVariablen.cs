using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Projekt2003.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private ObservableCollection<ComboBoxItem> _itemsList;

    [ObservableProperty] private ImageSource _image00;
    [ObservableProperty] private ImageSource _image10;
    [ObservableProperty] private ImageSource _image20;
    [ObservableProperty] private ImageSource _image01;
    [ObservableProperty] private ImageSource _image11;
    [ObservableProperty] private ImageSource _image21;
    [ObservableProperty] private ImageSource _image02;
    [ObservableProperty] private ImageSource _image12;
    [ObservableProperty] private ImageSource _image22;


    [ObservableProperty] private Visibility? _visibility00;
    [ObservableProperty] private Visibility? _visibility01;
    [ObservableProperty] private Visibility? _visibility02;

    [ObservableProperty] private Visibility? _visibility10;
    [ObservableProperty] private Visibility? _visibility11;
    [ObservableProperty] private Visibility? _visibility12;

    [ObservableProperty] private Visibility? _visibility20;
    [ObservableProperty] private Visibility? _visibility21;
    [ObservableProperty] private Visibility? _visibility22;
}
