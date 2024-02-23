namespace Projekt2005;

public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public Model.Model Model { get; set; }
    public ViewModel.ViewModel ViewModel { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();
        Model = new Model.Model();
        ViewModel = new ViewModel.ViewModel(Model, CancellationTokenSource);

        InitializeComponent();
        DataContext = ViewModel;
    }
    private void OnButtonKeyDown(object sender, System.Windows.Input.KeyEventArgs e) => Model.OnButtonKeyDown(e.Key, false);
}
