using System.Windows.Input;
// ReSharper disable ArrangeMethodOrOperatorBody

namespace Projekt2005.Model;

public partial class Model
{
    public const int AnzahlIndizes = 3;
    public int[,] Spielfeld { get; set; }

    private readonly Random _random;

    public Model()
    {
        _random = new Random();

        Spielfeld = new int[1 + AnzahlIndizes, 1 + AnzahlIndizes];
        SpielfeldInitialisieren();
    }
    public void OnButtonKeyDown(Key key, bool unitTests)
    {
        // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
        switch (key)
        {
            case Key.Up: SpielfeldNachObenSchieben(); break;
            case Key.Down: SpielfeldNachUntenSchieben(); break;
            case Key.Left: SpielfeldNachLinksSchieben(); break;
            case Key.Right: SpielfeldNachRechtsSchieben(); break;
        }

        if (unitTests) { return; }
        LeeresFeldFuellen(_random.Next(1, 3));
    }
    public void Reset()
    {
        Array.Clear(Spielfeld);
        SpielfeldInitialisieren();
    }
    private void SpielfeldInitialisieren()
    {
        LeeresFeldFuellen(_random.Next(1, 3));
        LeeresFeldFuellen(_random.Next(1, 3));
    }
    public void LeeresFeldFuellen(int zahl)
    {
        _ = zahl;
    }
}
