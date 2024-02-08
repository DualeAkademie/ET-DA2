using System;
using System.Threading;
using System.Windows.Controls;

namespace Projekt512;

// ReSharper disable once UnusedMember.Global
public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }

    private readonly ViewModel.ViewModel _viewModel;

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();

        _viewModel = new ViewModel.ViewModel(CancellationTokenSource);

        InitializeComponent();
        DataContext = _viewModel;
    }

    internal void Winkel3Geaendert(object sender, SelectionChangedEventArgs args)
    {
        if ((sender as ComboBox)?.SelectedItem is not ComboBoxItem cBoxItem) { return; }

        var content = cBoxItem.Content.ToString();
        _ = Enum.TryParse(content?.Remove(content.Length - 1, 1), true, out Model.BildDrehen.Winkel winkel);

        _viewModel.Winkel3Aendern(winkel);
    }

    internal void Winkel4Geaendert(object sender, SelectionChangedEventArgs args)
    {
        if ((sender as ComboBox)?.SelectedItem is not ComboBoxItem cBoxItem) { return; }

        var content = cBoxItem.Content.ToString();
        _ = Enum.TryParse(content?.Remove(content.Length - 1, 1), true, out Model.BildDrehen.Winkel winkel);

        _viewModel.Winkel4Aendern(winkel);
    }
    internal void Winkel5Geaendert(object sender, SelectionChangedEventArgs args)
    {
        if ((sender as ComboBox)?.SelectedItem is not ComboBoxItem cBoxItem) { return; }

        var content = cBoxItem.Content.ToString();
        _ = Enum.TryParse(content?.Remove(content.Length - 1, 1), true, out Model.BildDrehen.Winkel winkel);

        _viewModel.Winkel5Aendern(winkel);
    }
    internal void Winkel6Geaendert(object sender, SelectionChangedEventArgs args)
    {
        if ((sender as ComboBox)?.SelectedItem is not ComboBoxItem cBoxItem) { return; }

        var content = cBoxItem.Content.ToString();
        _ = Enum.TryParse(content?.Remove(content.Length - 1, 1), true, out Model.BildDrehen.Winkel winkel);

        _viewModel.Winkel6Aendern(winkel);
    }
}
