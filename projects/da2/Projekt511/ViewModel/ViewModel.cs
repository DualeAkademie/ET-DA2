using CommunityToolkit.Mvvm.ComponentModel;
using Projekt511.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

namespace Projekt511.ViewModel;

public partial class ViewModel : ObservableObject
{
    public ObservableCollection<StatistikText> StatistiksText { get; set; } = [];
    public ObservableCollection<StatistikWerk> StatistiksWerk { get; set; } = [];

    private readonly ModelTexte _modelTexte;
    private readonly MainWindow _mainWindow;

    private Dictionary<char, int>? _anzahlProZeichen = [];
    private Dictionary<char, int>? _anzahlProZeichenDe = [];
    private Dictionary<char, int>? _anzahlProZeichenEn = [];
    private Dictionary<char, int>? _anzahlProZeichenFr = [];
    private Dictionary<char, int>? _anzahlProZeichenWerk = [];

    public ViewModel(ModelTexte modelTexte, MainWindow mainWindow)
    {
        _modelTexte = modelTexte;
        _mainWindow = mainWindow;

        StringKompletterText = "";
        StringAnzahlZeichen = "Keine Datei geladen";
    }
}
