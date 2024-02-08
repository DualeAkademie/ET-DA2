using System.Collections.ObjectModel;
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

namespace Projekt520.Daten;
public class Bahnstrecke
{
    public string? Bezeichnung { get; set; }
    public string? Url { get; set; }
    public ObservableCollection<Bahnhoefe>? Bahnhoefe { get; set; }
}

public class Bahnhoefe
{
    public string? Name { get; set; }
    public double Position { get; set; }
    // ReSharper disable once UnusedMember.Global
    public int? Hoehe { get; set; }
}
