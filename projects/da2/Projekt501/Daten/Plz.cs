using System;
using System.Collections.ObjectModel;

namespace Projekt501.Daten;

public class Plz
{
    // ReSharper disable UnusedMember.Global
    public string? Message { get; set; }
    public int Status { get; set; }
    public DateTime Timestamp { get; set; }
    public ObservableCollection<Data>? Data { get; set; }
    public Version? Version { get; set; }
    // ReSharper restore UnusedMember.Global
}
public class Data
{
    // ReSharper disable UnusedMember.Global
    public int Plz { get; set; }
    public string? Ort { get; set; }
    public string? Bezirk { get; set; }
    public string? Bundesland { get; set; }
    public DateOnly? Gueltigab { get; set; }
    public DateOnly? Gueltigbis { get; set; }
    public string? PlzTyp { get; set; }
    public string? InternExtern { get; set; }
    public string? Adressierbar { get; set; }
    public string? Postfach { get; set; }
    // ReSharper restore UnusedMember.Global
}
public class Version
{
    // ReSharper disable UnusedMember.Global
    public int Id { get; set; }
    public DateTime Published { get; set; }
    // ReSharper restore UnusedMember.Global
}
