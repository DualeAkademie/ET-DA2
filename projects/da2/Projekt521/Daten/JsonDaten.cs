using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Globalization;

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local

namespace Projekt521.Daten;

public class PvWp
{
    public string? Url { get; set; }
    public string? Kurzbezeichnung { get; set; }
    public string? Langbezeichnung { get; set; }
    public ObservableCollection<Datenpunkte>? Datenpunkte { get; set; }
}
public class Datenpunkte
{
    [JsonConverter(typeof(DateOnlyJsonConverter))]
    public DateOnly? Date { get; set; }
    public TimeOnly? Time { get; set; }
    public double? Leistung { get; set; }
}
public class VdewLastProfile
{
    public string? Url { get; set; }
    public ObservableCollection<VdewProfile>? VdewProfile { get; set; }
}
public class VdewProfile
{
    public string? Kurzbezeichnung { get; set; }
    public string? Langbezeichnung { get; set; }
    public ObservableCollection<TagesDaten>? TagesDaten { get; set; }
}
public class TagesDaten
{
    public TimeOnly? Time { get; set; }
    public double? WinterSamstag { get; set; }
    public double? WinterSonntag { get; set; }
    public double? WinterWerktag { get; set; }
    public double? SommerSamtag { get; set; }
    public double? SommerSonntag { get; set; }
    public double? SommerWerktag { get; set; }
    public double? UebergangszeitSamstag { get; set; }
    public double? UebergangszeitSonntag { get; set; }
    public double? UebergangszeitWerktag { get; set; }
}
public class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
    private const string DateFormat = "dd.MM.yyyy";
    public override DateOnly ReadJson(JsonReader reader, Type objectType, DateOnly existingValue, bool hasExistingValue, JsonSerializer serializer) => DateOnly.ParseExact((string) reader.Value!, DateFormat, CultureInfo.InvariantCulture);
    public override void WriteJson(JsonWriter writer, DateOnly value, JsonSerializer serializer) => writer.WriteValue(value.ToString(DateFormat, CultureInfo.InvariantCulture));
}
