using System.Threading;
using System.Windows.Controls;

namespace Projekt501;

// ReSharper disable once UnusedMember.Global
public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public Model.ModelProjekt ModelProjekt { get; set; }
    public ViewModel.VmProjekt VmProjekt { get; set; }

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();

        ModelProjekt = new Model.ModelProjekt("Daten\\plz.json");
        VmProjekt = new ViewModel.VmProjekt(this, ModelProjekt);

        InitializeComponent();
        DataContext = VmProjekt;

        VmProjekt.AlleBezirkeEinlesen();
    }
    private void BezirkGeaendert(object sender, SelectionChangedEventArgs e) => VmProjekt.BezirkGeaendert(e);
}
