using System.IO;
using System.Reflection;
using System.Windows.Media.Imaging;
// ReSharper disable RedundantJumpStatement
// ReSharper disable LocalVariableHidesMember
// ReSharper disable InconsistentNaming
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0169 // Field is never used
// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Local
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ArrangeMethodOrOperatorBody
// ReSharper disable UnusedMember.Local
// ReSharper disable CollectionNeverUpdated.Local
#pragma warning disable IDE0022

namespace Projekt2003.Model;

public class Model
{
    public Kachel[,] AlleKacheln { get; set; }
    public int PuzzleGroesse = 3;

    private readonly MainWindow _mainWindow;
    private int _bilderNummer;
    private string? _bildName;
    private const string BildPfad = "Pictures";

    public Model(MainWindow mainWindow)
    {
        _mainWindow = mainWindow;
        //
        SetNeuesBild();
    }
    public void SetNeuesBild()
    {
        //
    }
    public void PuzzleMischen()
    {
        //
    }
    public void MouseClick(string? feld)
    {
        if (feld == null) { return; }
        //
    }
    private void DemoCode()
    {
        //
        // Democode zum lesen von Bildern aus dem Projekt
        //

        List<string?> bilderListe = [];

        var resources = Assembly.GetExecutingAssembly().GetManifestResourceNames();
        bilderListe.AddRange(resources.Where(resource => resource.Contains(BildPfad)));

        var _bildName = bilderListe[0];


        var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_bildName!) ?? throw new Exception("Image nicht gefunden:" + _bildName);
        stream.Position = 0;

        var bitmapImage = new BitmapImage();
        bitmapImage.BeginInit();
        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
        bitmapImage.StreamSource = stream;
        bitmapImage.EndInit();
    }
    private static BitmapImage GetImage(BitmapSource source, BitmapEncoder encoder)
    {
        var bmpImage = new BitmapImage();

        using var srcMs = new MemoryStream();
        encoder.Frames.Add(BitmapFrame.Create(source));
        encoder.Save(srcMs);

        srcMs.Position = 0;
        using var destMs = new MemoryStream(srcMs.ToArray());
        bmpImage.BeginInit();
        bmpImage.StreamSource = destMs;
        bmpImage.CacheOption = BitmapCacheOption.OnLoad;
        bmpImage.EndInit();
        bmpImage.Freeze();

        return bmpImage;
    }
}
