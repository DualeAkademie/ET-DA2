using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt401.Model;

public class ModelProjekt
{
    public bool Plus { get; set; }
    public bool Minus { get; set; }
    public int Zaehler { get; set; }


    public ModelProjekt(CancellationTokenSource cancellationTokenSource)
    {

        Log.Debug("ModelProjekt gestartet");

        Zaehler = 10;
        _ = Task.Run(() => ModelTask(cancellationTokenSource.Token));
    }

    private void ModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            if (Plus) { Zaehler++; }
            if (Minus) { Zaehler--; }

            Thread.Sleep(100);
        }
    }
}
