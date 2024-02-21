using Projekt523.Model;

namespace Projekt523;

public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public ModelGpx ModelGps { get; set; }
    public ViewModel.ViewModel ViewModel { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();

        ModelGps = new ModelGpx();
        ViewModel = new ViewModel.ViewModel(CancellationTokenSource, this, ModelGps);

        InitializeComponent();
        DataContext = ViewModel;
    }
}
