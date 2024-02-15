using System.Windows;

namespace Projekt2002.Model;

public class Spielsteine(int zahl)
{
    private Visibility _sichtbarkeit;
    private string? _zahl = zahl.ToString();
}
