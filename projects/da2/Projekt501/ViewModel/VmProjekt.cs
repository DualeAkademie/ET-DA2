using CommunityToolkit.Mvvm.ComponentModel;
using Projekt501.Model;
using System.Linq;
using System.Windows.Controls;

namespace Projekt501.ViewModel;

public partial class VmProjekt : ObservableObject
{

    private readonly MainWindow _mainWindow;
    private readonly ModelProjekt _modelProjekt;

    public VmProjekt(MainWindow mainWindow, ModelProjekt modelProjekt)
    {
        _mainWindow = mainWindow;
        _modelProjekt = modelProjekt;
    }
    public void AlleBezirkeEinlesen()
    {
        var bezirke = _modelProjekt.Plz!.Data!.Select(item => item.Bezirk).Distinct().OrderBy(n => n);

        foreach (var b in bezirke)
        {
            _ = _mainWindow.ComboBox.Items.Add(b);
        }

        _mainWindow.ComboBox.SelectedIndex = 1;
    }
    public void BezirkGeaendert(SelectionChangedEventArgs e)
    {
        var bezirk = e.AddedItems[0]?.ToString();
        if (bezirk == null) { return; }

        DataGridZeilen.Clear();

        foreach (var data in _modelProjekt.Plz!.Data!)
        {
            if (data.Bezirk!.Contains(bezirk))
            {
                DataGridZeilen.Add(data);
            }
        }
    }
}
