using CommunityToolkit.Mvvm.ComponentModel;

namespace Projekt2003.ViewModel;

public partial class ViewModel : ObservableObject
{
    // ReSharper disable once NotAccessedField.Local
    private readonly Model.Model _model;
    private readonly CancellationTokenSource _cancellationTokenSource;



    public ViewModel(Model.Model model, CancellationTokenSource cancellationTokenSource)
    {
        _model = model;
        _cancellationTokenSource = cancellationTokenSource;


        _ = Task.Run(VmTask);
    }
    private void VmTask()
    {
        while (!_cancellationTokenSource.IsCancellationRequested)
        {


            Thread.Sleep(50);
        }
    }

}
