namespace Projekt2002.Model;

public class Model
{
    public Spielsteine[,] Puzzle { get; set; }

    private const int PuzzleGroesse = 4;

    public Model()
    {
        Puzzle = new Spielsteine[PuzzleGroesse, PuzzleGroesse];
        Reset();
    }
    public void Reset()
    {
       //
    }
}
