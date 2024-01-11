using Projekt522.Model;

namespace Projekt522;

public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public ModelMorsen ModelMorsen { get; set; }
    public ViewModel.ViewModel ViewModel { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();

        ModelMorsen = new ModelMorsen();
        ViewModel = new ViewModel.ViewModel(CancellationTokenSource, this);


        InitializeComponent();
        DataContext = ViewModel;
    }
}
