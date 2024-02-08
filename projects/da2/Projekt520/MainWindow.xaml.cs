using System.Windows;
using System.Windows.Controls;

// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

namespace Projekt520;

public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }

    public ViewModel.ViewModel ViewModel { get; set; }
    public Model.Bildfahrplan Bildfahrplan { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();

        Bildfahrplan = new Model.Bildfahrplan();
        ViewModel = new ViewModel.ViewModel(Bildfahrplan, this, CancellationTokenSource);

        InitializeComponent();
        DataContext = ViewModel;
    }
    private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // ReSharper disable once UnusedVariable
        if (sender is not TabControl tabControl) { return; }


    }

    private void CheckboxClicked(object sender, RoutedEventArgs routedEventArgs)
    {
        if (sender is not CheckBox) { return; }

    }
}
