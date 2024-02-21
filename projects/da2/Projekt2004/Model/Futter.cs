
using System.Windows.Controls;
// ReSharper disable ArrangeMethodOrOperatorBody
// ReSharper disable UnusedMember.Local
// ReSharper disable CollectionNeverUpdated.Local
#pragma warning disable CS9113 // Parameter is unread.
#pragma warning disable IDE0022


namespace Projekt2004.Model;


public class Futter(Model model)

{

    private readonly List<(int x, int y)> _koordinaten = [];

    public void Zeichnen(Canvas canvas)
    {
        _ = canvas;
    }
}
