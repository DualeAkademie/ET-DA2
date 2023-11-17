using CommunityToolkit.Mvvm.Input;

namespace Projekt301.ViewModel;

public partial class VmProjekt
{
    [RelayCommand]
    private void ButtonTaster(string? taster)
    {


        switch (taster)
        {
            case "+": (_modelProjekt.Plus, ClickModePlus) = Contracts.Basefunktions.ButtonClickMode(ClickModePlus); break;
            case "-": (_modelProjekt.Minus, ClickModeMinus) = Contracts.Basefunktions.ButtonClickMode(ClickModeMinus); break;
        }
    }
}
