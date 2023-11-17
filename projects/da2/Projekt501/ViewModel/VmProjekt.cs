using CommunityToolkit.Mvvm.ComponentModel;
using Projekt501.Model;
using System.Linq;
using System.Windows.Controls;

namespace Projekt501.ViewModel;

public partial class VmProjekt(MainWindow mainWindow, ModelProjekt modelProjekt) : ObservableObject
{
    public void AlleBezirkeEinlesen()
    {
        var bezirke = modelProjekt.Plz!.Data!.Select(item => item.Bezirk).Distinct().OrderBy(n => n);

        foreach (var b in bezirke)
        {
            _ = mainWindow.ComboBox.Items.Add(b);
        }

        mainWindow.ComboBox.SelectedIndex = 1;
    }
    public void BezirkGeaendert(SelectionChangedEventArgs e)
    {
        var bezirk = e.AddedItems[0]?.ToString();
        if (bezirk == null) { return; }

        DataGridZeilen.Clear();

        foreach (var data in modelProjekt.Plz!.Data!)
        {
            if (data.Bezirk!.Contains(bezirk))
            {
                DataGridZeilen.Add(data);
            }
        }
    }
}
