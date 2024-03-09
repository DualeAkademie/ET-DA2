using System.Windows.Controls;

namespace Projekt524;


public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public Model.Model Model { get; set; }
    public ViewModel.ViewModel ViewModel { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();

        Model = new Model.Model();
        ViewModel = new ViewModel.ViewModel(Model);

        InitializeComponent();

        DataContext = ViewModel;
    }

    private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is not TabControl { SelectedValue: TabItem item }) { return; }

        _ = item;
    }
}
