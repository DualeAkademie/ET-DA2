using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
// ReSharper disable ArrangeMethodOrOperatorBody
// ReSharper disable UnusedMember.Local
// ReSharper disable CollectionNeverUpdated.Local
#pragma warning disable IDE0022

namespace Projekt2004.Model;


public class Snake(Model model)
{
    private readonly List<(int x, int y)> _koordinaten = [];


    public static Brush ConvertColor(int r, int g, int b) => new SolidColorBrush(Color.FromRgb(Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
  
    internal void Zeichnen(Canvas canvas)
    {
        if (_koordinaten.Count == 0) { return; }

        for (var i = 0; i < _koordinaten.Count; i++)
        {
            (int x, int y) = _koordinaten[i];
            Brush farbe = Brushes.Red;

            if (i > 0 && _koordinaten.Count > 1)
            {
                var prozent = (double) i / _koordinaten.Count;

                var red = 255 * (1 - prozent);
                var green = 255 * prozent;
                var blue = 128 * Math.Abs(0.5 - prozent);

                farbe = ConvertColor((int) red, (int) green, (int) blue);
            }

            var rect = new Rectangle
            {
                Width = model.Raster,
                Height = model.Raster,
                Fill = farbe
            };

            Canvas.SetLeft(rect, x * model.Raster);
            Canvas.SetTop(rect, y * model.Raster);
            _ = canvas.Children.Add(rect);
        }
    }
    public void Bewegen(Model.Richtung snakeRichtung)
    {
        _ = snakeRichtung;
    }
}
