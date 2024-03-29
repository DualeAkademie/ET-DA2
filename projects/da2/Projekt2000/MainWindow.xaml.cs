namespace Projekt2000;



public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public Model.Model Model { get; set; }
    public ViewModel.ViewModel ViewModel { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();
        Model = new Model.Model();
        ViewModel = new ViewModel.ViewModel(this, Model, CancellationTokenSource);

        InitializeComponent();
        DataContext = ViewModel;
    }
}
