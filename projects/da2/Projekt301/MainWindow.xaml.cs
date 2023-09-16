using System.Threading;

namespace Projekt301;

// ReSharper disable once UnusedMember.Global
public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }

    private static readonly log4net.ILog s_log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);


    public MainWindow()
    {
        s_log.Debug("MainWindow startet");

        CancellationTokenSource = new CancellationTokenSource();

        var modelProjekt = new Model.ModelProjekt(CancellationTokenSource);
        var vmProjekt = new ViewModel.VmProjekt(modelProjekt, CancellationTokenSource);

        InitializeComponent();
        DataContext = vmProjekt;
    }
}
