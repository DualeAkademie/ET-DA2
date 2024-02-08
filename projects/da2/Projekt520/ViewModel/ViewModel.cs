using CommunityToolkit.Mvvm.ComponentModel;
using Projekt520.Model;
#pragma warning disable CS0169 // Field is never used
#pragma warning disable CS0414 // Field is assigned but its value is never used

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

namespace Projekt520.ViewModel;

public partial class ViewModel : ObservableObject
{
    private readonly Bildfahrplan? _bildfahrplan;
    private readonly MainWindow _mainWindow;

    private bool _wegZeitDiagrammAktiv = true;

    private readonly double[]? _doubleS1Strecke;
    private readonly double[]? _doubleRex1Strecke;
    private double[]? _doubleS1Sued1;
    private double[]? _doubleS1Sued2;
    private double[]? _doubleS1Sued3;
    private double[]? _doubleS1Sued4;
    private double[]? _doubleS1Nord1;
    private double[]? _doubleS1Nord2;
    private double[]? _doubleS1Nord3;
    private double[]? _doubleS1Nord4;
    private double[]? _doubleRex1Sued1;
    private double[]? _doubleRex1Sued2;
    private double[]? _doubleRex1Sued3;
    private double[]? _doubleRex1Sued4;
    private double[]? _doubleRex1Nord1;
    private double[]? _doubleRex1Nord2;
    private double[]? _doubleRex1Nord3;
    private double[]? _doubleRex1Nord4;

    public ViewModel(Bildfahrplan? bildfahrplan, MainWindow mainWindow, CancellationTokenSource cancellationTokenSource)
    {
        _bildfahrplan = bildfahrplan;
        _mainWindow = mainWindow;


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
            if (!BoolS1Sued1)
            {
                BoolS1Sued2 = false;
                BoolS1Sued3 = false;
                BoolS1Sued4 = false;
            }

            if (!BoolS1Nord1)
            {
                BoolS1Nord2 = false;
                BoolS1Nord3 = false;
                BoolS1Nord4 = false;
            }

            if (!BoolRex1Sued1)
            {
                BoolRex1Sued2 = false;
                BoolRex1Sued3 = false;
                BoolRex1Sued4 = false;
            }

            if (!BoolRex1Nord1)
            {
                BoolRex1Nord2 = false;
                BoolRex1Nord3 = false;
                BoolRex1Nord4 = false;
            }

            Thread.Sleep(100);
        }
    }
}
