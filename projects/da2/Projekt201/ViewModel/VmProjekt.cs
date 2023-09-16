using CommunityToolkit.Mvvm.ComponentModel;
using Projekt201.Model;
using System.Windows.Controls;

namespace Projekt201.ViewModel;

public partial class VmProjekt : ObservableObject
{
    private readonly ModelProjekt _modelProjekt;

    public VmProjekt(ModelProjekt modelProjekt, CancellationTokenSource cancellationTokenSource)
    {
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
