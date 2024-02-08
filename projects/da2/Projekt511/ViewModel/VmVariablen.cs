using CommunityToolkit.Mvvm.ComponentModel;

namespace Projekt511.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private string? _stringAnzahlZeichen;
    [ObservableProperty] private string? _stringAnzahlZeichenDe;
    [ObservableProperty] private string? _stringAnzahlZeichenEn;
    [ObservableProperty] private string? _stringAnzahlZeichenFr;
    [ObservableProperty] private string? _stringKompletterText;
    [ObservableProperty] private string? _stringKompletterTextDe;
    [ObservableProperty] private string? _stringKompletterTextEn;
    [ObservableProperty] private string? _stringKompletterTextFr;
}
