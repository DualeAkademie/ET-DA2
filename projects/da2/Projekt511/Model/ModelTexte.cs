using Microsoft.Win32;
using System;
using System.IO;
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Global

namespace Projekt511.Model;

public class ModelTexte
{
    private string? _werkDe;
    private string? _werkEn;
    private string? _werkFr;
    private string? _textInhalt;

    public void TextOeffnen()
    {
        var aktuellerOrdner = Directory.GetCurrentDirectory();

        try
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = aktuellerOrdner + "\\Texte",
                DefaultExt = "txt"
            };
            if (openFileDialog.ShowDialog() == true) { _textInhalt = File.ReadAllText(openFileDialog.FileName); }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public void WerkOeffnen()
    {
        var aktuellerOrdner = Directory.GetCurrentDirectory();

        try
        {
            var dialog = new OpenFolderDialog { InitialDirectory = aktuellerOrdner + "\\Texte" };
            if (dialog.ShowDialog() != true) { return; }

            _werkDe = File.ReadAllText(Path.Combine(dialog.FolderName, "de.txt"));
            _werkEn = File.ReadAllText(Path.Combine(dialog.FolderName, "en.txt"));
            _werkFr = File.ReadAllText(Path.Combine(dialog.FolderName, "fr.txt"));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
