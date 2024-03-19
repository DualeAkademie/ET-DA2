namespace Projekt2004;

public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public Model.Model Model { get; set; }
    public ViewModel.ViewModel ViewModel { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();
        Model = new Model.Model(this, CancellationTokenSource);
        ViewModel = new ViewModel.ViewModel(Model, CancellationTokenSource);

        InitializeComponent();
        DataContext = ViewModel;

        ViewModel.SetCanvas(Canvas);

        Model.SetCanvas(Canvas);
        Model.FeldInitialisieren();
    }

    private void OnButtonKeyDown(object sender, System.Windows.Input.KeyEventArgs e) => Model.OnButtonKeyDown(e);
}
