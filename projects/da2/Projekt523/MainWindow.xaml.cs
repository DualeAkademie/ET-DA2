using System.Windows.Controls;
// ReSharper disable ConvertToConstant.Local

namespace Projekt523;

public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public Model.Model Model { get; set; }
    public ViewModel.ViewModel ViewModel { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();

        Model = new Model.Model();
        ViewModel = new ViewModel.ViewModel(CancellationTokenSource, this, Model);

        InitializeComponent();
        DataContext = ViewModel;
    }

    private void ComboBoxAvgChanged(object sender, SelectionChangedEventArgs e)
    {

        if (ComboBoxAvg.SelectedItem is null) { return; }
        if (ComboBoxNum.SelectedItem is null) { return; }
        if (ComboBoxBeschleunigung.SelectedItem is null) { return; }

        var type = "??";
        var num = 0;
        var beschleunigung = 0;
        
        Model.SetNeuerMittelwert(type, num, beschleunigung);
        ViewModel.MittelwertUpdaten();
    }

}
