using System.Threading;

namespace Projekt130;

// ReSharper disable once UnusedMember.Global
public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }


    public MainWindow()
    {

        CancellationTokenSource = new CancellationTokenSource();

        var modelProjekt = new Model.ModelProjekt(CancellationTokenSource);
        var vmProjekt = new ViewModel.VmProjekt(modelProjekt, CancellationTokenSource);

        InitializeComponent();
        DataContext = vmProjekt;

    }
}
