using System.IO;
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedVariable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0169 // Field is never used

namespace Projekt524.Model;

public class Model
{
    private readonly string[] _vorNamen;
    private readonly string[] _nachNamen;
    private readonly string[] _geburtsTage;

    public Model()
    {
        _vorNamen = File.ReadAllLines(Path.Combine("Daten", "Vorname.txt"));
        _nachNamen = File.ReadAllLines(Path.Combine("Daten", "Nachname.txt"));
        string[] geburtsDatum = File.ReadAllLines(Path.Combine("Daten", "Geburtsdatum.txt"));
      }
}
