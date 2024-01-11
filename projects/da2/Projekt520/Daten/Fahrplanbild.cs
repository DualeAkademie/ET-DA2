using System.Collections.ObjectModel;

namespace Projekt520.Daten;
public class Fahrplanbild
{
    public string? Bezeichnung { get; set; }
    public string? Url { get; set; }
    public ObservableCollection<Zuege>? Zuege { get; set; }
}
public class Zuege
{
    public string? Bezeichnung { get; set; }
    public int Nummer { get; set; }
    public string? Richtung { get; set; }
    public ObservableCollection<Data>? Data { get; set; }
}
public class Data
{
    public string? Name { get; set; }
    public TimeOnly? An { get; set; }
    public TimeOnly? Ab { get; set; }
}
