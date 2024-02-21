using System.Windows.Controls;
using System.Windows.Input;
// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Local
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ArrangeMethodOrOperatorBody
// ReSharper disable UnusedMember.Local
// ReSharper disable CollectionNeverUpdated.Local
#pragma warning disable IDE0022

namespace Projekt2004.Model;



public class Model
{
    public enum Richtung
    {
        Stehen,
        NachOben,
        NachUnten,
        NachRechts,
        NachLinks
    }
    public bool SpielAktiv;

    public int Raster = 10;
    public int AnzahlPunkte;

    public Futter Futter { get; set; }
    public Snake Snake { get; set; }

    public Richtung SnakeRichtung { get; set; }
    public double Geschwindigkeit = 200;
    public const double StartGeschwindigkeit = 200;
    public const double DeltaGeschwindigkeit = 5;
    public const double MaxGeschwindigkeit = 50;

    private readonly MainWindow _mainWindow;
    private readonly CancellationTokenSource _cancellationTokenSource;
    private Canvas? _canvas;

    private int _breite;
    private int _hoehe;

    public Model(MainWindow mainWindow, CancellationTokenSource cancellationTokenSource)
    {
        _mainWindow = mainWindow;
        _cancellationTokenSource = cancellationTokenSource;

        SnakeRichtung = Richtung.Stehen;

        Futter = new Futter(this);
        Snake = new Snake(this);


        _ = Task.Run(ModelTask);
    }
    private void ModelTask()
    {
        while (!_cancellationTokenSource.IsCancellationRequested)
        {
            Thread.Sleep((int) Geschwindigkeit);

            if (_canvas == null || !SpielAktiv) { continue; }

            Snake.Bewegen(SnakeRichtung);
            FutterGefunden();
            RandErreicht();
            SchlangeBeisstSich();
        }
    }
    private void SchlangeBeisstSich()
    {
        //
    }
    private void RandErreicht()
    {
        //
    }
    private void FutterGefunden()
    {
        //
    }
    public void FeldInitialisieren()
    {
        //
    }
    public void OnButtonKeyDown(KeyEventArgs keyEventArgs)
    {
        _ = keyEventArgs;
    }
    public void SetCanvas(Canvas canvas)
    {
        _canvas = canvas;
        _breite = (int) canvas.Width / Raster;
        _hoehe = (int) canvas.Height / Raster;
    }
    internal void Reset()
    {
        //
    }
}
