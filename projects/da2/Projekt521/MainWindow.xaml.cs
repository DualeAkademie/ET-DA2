using Projekt521.Model;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace Projekt521;

public partial class MainWindow
{
    public enum TabBezeichnung
    {
        PvWp,
        PvWpAkku,
        Kennlinien,
        None
    }
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public AlleDaten AlleDaten { get; set; }
    public ViewModel.ViewModel ViewModel { get; set; }

    public TabBezeichnung TabBez { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();

        AlleDaten = new AlleDaten();
        ViewModel = new ViewModel.ViewModel(CancellationTokenSource, AlleDaten, this);

        InitializeComponent();
        DataContext = ViewModel;
    }
    private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is not TabControl tabControl) { return; }

        TabBez = tabControl.SelectedIndex switch
        {
            (int) TabBezeichnung.PvWp => TabBezeichnung.PvWp,
            (int) TabBezeichnung.PvWpAkku => TabBezeichnung.PvWpAkku,
            (int) TabBezeichnung.Kennlinien => TabBezeichnung.Kennlinien,
            _ => TabBez
        };
        ViewModel.UpdatePlotWindowKennlinie(TabBez, "-", false, "-");
    }
    private void DateChanged(object sender, EventArgs e)
    {
        if (sender is not DatePicker) { return; }
        ViewModel.UpdatePlotWindowKennlinie(TabBez, "-", false, "-");
    }
    private void SollwerteUpdate(object sender, TextChangedEventArgs e)
    {
        if (sender is not TextBox textBox) { return; }
        ViewModel.UpdatePlotWindowKennlinie(TabBez, "-", true, textBox.Name);
    }
    private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
    {
        Regex regex = MyRegex();
        e.Handled = regex.IsMatch(e.Text);
    }

    [GeneratedRegex("[^0-9]+")]
    private static partial Regex MyRegex();
}
