using CommunityToolkit.Mvvm.ComponentModel;
using Projekt1000.DbModel;
using System.Collections.ObjectModel;

namespace Projekt1000.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private ObservableCollection<Category> _categories;
    [ObservableProperty] private ObservableCollection<Product> _products;
    [ObservableProperty] private ObservableCollection<DbContext.Uebersicht> _uebersicht;
}
