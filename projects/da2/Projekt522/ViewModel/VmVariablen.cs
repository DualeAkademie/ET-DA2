using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Media;

namespace Projekt522.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private Brush _brushLampe;

    [ObservableProperty] private int _intGeschwindigkeit;

    [ObservableProperty] private string _stringAktuellesZeichen;
    [ObservableProperty] private string _stringEingabe;
}
