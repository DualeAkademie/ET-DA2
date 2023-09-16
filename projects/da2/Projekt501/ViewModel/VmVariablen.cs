using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Projekt501.ViewModel;

public partial class VmProjekt
{
    [ObservableProperty] private ObservableCollection<Daten.Data> _dataGridZeilen = new();
}
