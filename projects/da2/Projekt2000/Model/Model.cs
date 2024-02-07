namespace Projekt2000.Model;

public class Model
{
    public Spielfeld[,] SpielFelder { get; set; }

    private const int SpielfeldGroesse = 3;

    public Model()
    {
        SpielFelder = new Spielfeld[SpielfeldGroesse, SpielfeldGroesse];
        Reset();
    }
    public void Reset()
    {
        //
    }


    // ReSharper disable once UnusedMember.Global
    public static void AlleXy(Action<int, int> action)
    {
        for (var x = 0; x < SpielfeldGroesse; x++)
        {
            for (var y = 0; y < SpielfeldGroesse; y++) { action(x, y); }
        }
    }
}
