using CommunityToolkit.Mvvm.ComponentModel;
using Projekt301.Model;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Projekt301.ViewModel;

public partial class VmProjekt : ObservableObject
{
    private readonly ModelProjekt _modelProjekt;

    private static readonly log4net.ILog s_log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

    public VmProjekt(ModelProjekt modelProjekt, CancellationTokenSource cancellationTokenSource)
    {
        s_log.Debug("Konstruktor ViewModel");

        _modelProjekt = modelProjekt;

        ClickModeMinus = ClickMode.Press;
        ClickModePlus = ClickMode.Press;

        StringText = "";

        _ = Task.Run(() => ModelTask(cancellationTokenSource.Token));
    }
    private void ModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            StringText = $"Aktueller Zählerstand: {_modelProjekt.Zaehler:D2}";

            Thread.Sleep(100);
        }
    }
}
