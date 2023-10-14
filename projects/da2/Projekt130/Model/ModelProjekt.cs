using System.Threading;
using System.Threading.Tasks;

namespace Projekt130.Model;

public class ModelProjekt
{
    public bool Plus { get; set; }
    public bool Minus { get; set; }
    public int Zaehler { get; set; }


    public ModelProjekt(CancellationTokenSource cancellationTokenSource)
    {

        
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
