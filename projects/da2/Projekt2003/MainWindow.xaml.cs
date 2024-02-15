namespace Projekt2003;

public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public Model.Model Model { get; set; }
    public ViewModel.ViewModel ViewModel { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();
        Model = new Model.Model(this);
        ViewModel = new ViewModel.ViewModel(Model, CancellationTokenSource);

        InitializeComponent();
        DataContext = ViewModel;
    }
}
