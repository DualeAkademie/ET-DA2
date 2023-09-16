using Serilog;
using System.Threading;

namespace Projekt401;

// ReSharper disable once UnusedMember.Global
public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }


    public MainWindow()
    {

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Debug()
            .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        Log.Debug("MainWindow gestartet");

        CancellationTokenSource = new CancellationTokenSource();

        var modelProjekt = new Model.ModelProjekt(CancellationTokenSource);
        var vmProjekt = new ViewModel.VmProjekt(modelProjekt, CancellationTokenSource);

        InitializeComponent();
        DataContext = vmProjekt;

        Log.CloseAndFlush();
    }
}
