using CommunityToolkit.Mvvm.ComponentModel;
using Projekt523.Model;
// ReSharper disable RedundantJumpStatement

namespace Projekt523.ViewModel;

// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Local
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ArrangeMethodOrOperatorBody
// ReSharper disable UnusedMember.Local
// ReSharper disable CollectionNeverUpdated.Local
#pragma warning disable IDE0022

public partial class ViewModel : ObservableObject
{
    private readonly MainWindow _mainWindow;
    private readonly ModelGpx _modelGps;

    public ViewModel(CancellationTokenSource cancellationTokenSource, MainWindow mainWindow, ModelGpx modelGps)
    {
        _mainWindow = mainWindow;
        _modelGps = modelGps;

        _ = Task.Run(() => ViewModelTask(cancellationTokenSource.Token));
    }

    private void ViewModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            Thread.Sleep(100);

            if (_modelGps.GpxReader == null) { continue; }
            
        }
    }
}
