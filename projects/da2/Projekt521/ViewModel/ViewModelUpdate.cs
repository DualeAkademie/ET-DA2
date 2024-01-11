namespace Projekt521.ViewModel;

public partial class ViewModel
{
    public void UpdatePlotWindowKennlinie(MainWindow.TabBezeichnung tabBezeichnung, string? taster, bool buttonGedrueckt, string? energieName)
    {
        if (_mainWindow.WpfPlotKennlinie == null) { return; }
        if (DateTimeStart > DateTimeEnd) { return; }
        if (_dtStartAlt == DateTimeStart && _dtEndAlt == DateTimeEnd && _tabBezeichnungAlt == tabBezeichnung && _tasterAlt == taster && !buttonGedrueckt) { return; }
    }
}
