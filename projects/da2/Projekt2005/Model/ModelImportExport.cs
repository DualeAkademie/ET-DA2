namespace Projekt2005.Model;

public partial class Model
{
    public void ImportSpielfeld(int[,] spielfeld) => Spielfeld = (int[,]) spielfeld.Clone();
    public int[,] ExportSpielfeld() => (int[,]) Spielfeld.Clone();
}
