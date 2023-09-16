using System.Threading;
using System.Threading.Tasks;

namespace Projekt301.Model;

public class ModelProjekt
{
    public bool Plus { get; set; }
    public bool Minus { get; set; }
    public int Zaehler { get; set; }

    private static readonly log4net.ILog s_log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

    public ModelProjekt(CancellationTokenSource cancellationTokenSource)
    {
        s_log.Debug("Konstruktur Model");

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
