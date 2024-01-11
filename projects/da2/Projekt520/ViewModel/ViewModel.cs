using CommunityToolkit.Mvvm.ComponentModel;
using Projekt520.Model;
using System.Windows;

namespace Projekt520.ViewModel;

public partial class ViewModel : ObservableObject
{
    private readonly Bildfahrplan? _bildfahrplan;
    private readonly MainWindow _mainWindow;

    private bool _wegZeitDiagrammAktiv = true;

    private readonly double[]? _doubleS1Strecke;
    private readonly double[]? _doubleRex1Strecke;


    public ViewModel(Bildfahrplan? bildfahrplan, MainWindow mainWindow, CancellationTokenSource cancellationTokenSource)
    {
        _bildfahrplan = bildfahrplan;
        _mainWindow = mainWindow;

        _doubleS1Strecke = _bildfahrplan?.GetTrasseStrecken(Bildfahrplan.Trassen.S1Nord);
        _doubleRex1Strecke = _bildfahrplan?.GetTrasseStrecken(Bildfahrplan.Trassen.Rex1Nord);

        //  BoolS1Sued1 = true;
        //  BoolS1Sued2 = true;
        //  BoolS1Sued3 = true;
        //  BoolS1Sued4 = true;
        BoolS1Nord1 = true;
        //  BoolS1Nord2 = true;
        //  BoolS1Nord3 = true;
        //  BoolS1Nord4 = true;
        //  BoolRex1Sued1 = true;
        //  BoolRex1Sued2 = true;
        //  BoolRex1Sued3 = true;
        //  BoolRex1Sued4 = true;
        //  BoolRex1Nord1 = true;
        //  BoolRex1Nord2 = true;
        //  BoolRex1Nord3 = true;
        //  BoolRex1Nord4 = true;

        IntS1Sued1 = 23;
        IntS1Sued2 = 53;
        IntS1Sued3 = 83;
        IntS1Sued4 = 113;

        IntS1Nord1 = 9;
        IntS1Nord2 = 39;
        IntS1Nord3 = 69;
        IntS1Nord4 = 99;

        IntRex1Sued1 = 25;
        IntRex1Sued2 = 55;
        IntRex1Sued3 = 85;
        IntRex1Sued4 = 115;

        IntRex1Nord1 = 0;
        IntRex1Nord2 = 30;
        IntRex1Nord3 = 60;
        IntRex1Nord4 = 90;

        _ = Task.Run(() => ModelTask(cancellationTokenSource.Token));
    }
    private void ModelTask(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {

            Thread.Sleep(100);
        }
    }
    public void UpdatePlotWindow(int selectedIndex)
    {
        _wegZeitDiagrammAktiv = selectedIndex == 0;
        UpdateWindow();
    }
    public void UpdateWindow()
    {
        if (_wegZeitDiagrammAktiv) { UpdatePlotWindowWegZeit(); }
        else { UpdatePlotWindowWegGeschwindigkeit(); }
    }
    private static Visibility Sichtbarkeit(bool b) => b ? Visibility.Visible : Visibility.Collapsed;
}
