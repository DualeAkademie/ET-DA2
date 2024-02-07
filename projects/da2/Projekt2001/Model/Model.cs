namespace Projekt2001.Model;

public class Model
{
    public SpielStein[,] AlleSpielSteine { get; set; }

    private const int SpielfeldGroesse = 7;

    public Model()
    {
        AlleSpielSteine = new SpielStein[SpielfeldGroesse, SpielfeldGroesse];
       

        Reset();
    }
    public void Reset()
    {
       //
    }


    // ReSharper disable once UnusedMember.Global
    public static void AlleXyAction(int min, int max, Action<int, int> action)
    {
        for (var x = min; x < max; x++)
        {
            for (var y = min; y < max; y++)
            {
                action(x, y);
            }
        }
    }
  
}
