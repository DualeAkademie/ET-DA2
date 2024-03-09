// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedVariable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0169 // Field is never used

using CommunityToolkit.Mvvm.ComponentModel;

namespace Projekt524.ViewModel;

public partial class ViewModel : ObservableObject
{
    private readonly Model.Model _model;

    public ViewModel(Model.Model model)
    {
        _model = model;

        InitGeburtsdatum();
        InitVorname();
        InitNachname();
    }
}
