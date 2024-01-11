using System.Collections.ObjectModel;

namespace Projekt520.Daten;
public class Bahnstrecke
{
    public string? Bezeichnung { get; set; }
    public string? Url { get; set; }
    // ReSharper disable once UnusedMember.Global
    public ObservableCollection<Bahnhoefe>? Bahnhoefe { get; set; }
}

public class Bahnhoefe
{
    public string? Name { get; set; }
    // ReSharper disable once UnusedMember.Global
    public double Position { get; set; }
    // ReSharper disable once UnusedMember.Global
    public int? Hoehe { get; set; }
}
