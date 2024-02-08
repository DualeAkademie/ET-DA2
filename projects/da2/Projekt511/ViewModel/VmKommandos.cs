using CommunityToolkit.Mvvm.Input;

namespace Projekt511.ViewModel;

public partial class ViewModel
{
    [RelayCommand]
    private void ButtonTaster(string? taster)
    {
        switch (taster)
        {
            case "Text":
                TextAnzeigeLoeschen();
                break;

            case "Werk":
                WerkAnzeigeLoeschen();
     break;
        }
    }
}
