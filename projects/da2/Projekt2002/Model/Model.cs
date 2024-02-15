// ReSharper disable NotAccessedField.Local
#pragma warning disable IDE0022
namespace Projekt2002.Model;

public class Model
{
    public Spielsteine[,] Puzzle { get; set; }

    private const int PuzzleGroesse = 4;
    private readonly MainWindow _mainWindow;

    public Model(MainWindow mainWindow)
    {
        _mainWindow = mainWindow;
        Puzzle = new Spielsteine[PuzzleGroesse, PuzzleGroesse];
        Reset();
    }
    public void Reset()
    {
        //
    }
    public void PuzzleDurchmischen() => Reset();
    public void MouseClick(string? feld) => _ = feld;
}
