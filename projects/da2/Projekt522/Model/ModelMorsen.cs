// ReSharper disable ReturnTypeCanBeNotNullable
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
namespace Projekt522.Model;

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantJumpStatement
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedMember.Local
public class ModelMorsen
{
    private const char Symbolabstand = ' ';
    private const string Buchstabenabstand = "   ";
    private const string Wortabstand = "       ";
    private const char ZeichenPunkt = '•';
    private const char ZeichenStrich = '—';
    private List<(char zeichen, string morsecode)>? _morseCodeListe;

    private readonly Dictionary<char, (byte bitmuster, byte anzahlBit)> _morseTabelle = new()
    {
       { 'A', (0b0000_0001, 2)},
       { 'B', (0b0000_1000, 4)},
       { 'C', (0b0000_1010, 4)},
       { 'D', (0b0000_0100, 3)},
       { 'E', (0b0000_0000, 1)},
       { 'F', (0b0000_0010, 4)},
       { 'G', (0b0000_0110, 3)},
       { 'H', (0b0000_0000, 4)},
       { 'I', (0b0000_0000, 2)},
       { 'J', (0b0000_0111, 4)},
       { 'K', (0b0000_0101, 3)},
       { 'L', (0b0000_0100, 4)},
       { 'M', (0b0000_0011, 2)},
       { 'N', (0b0000_0010, 2)},
       { 'O', (0b0000_0111, 3)},
       { 'P', (0b0000_0110, 4)},
       { 'Q', (0b0000_1101, 4)},
       { 'R', (0b0000_0010, 3)},
       { 'S', (0b0000_0000, 3)},
       { 'T', (0b0000_0001, 1)},
       { 'U', (0b0000_0001, 3)},
       { 'V', (0b0000_0001, 4)},
       { 'W', (0b0000_0011, 3)},
       { 'X', (0b0000_1001, 4)},
       { 'Y', (0b0000_1011, 4)},
       { 'Z', (0b0000_1100, 4)},
       { '0', (0b0001_1111, 5)},
       { '1', (0b0000_1111, 5)},
       { '2', (0b0000_0111, 5)},
       { '3', (0b0000_0011, 5)},
       { '4', (0b0000_0001, 5)},
       { '5', (0b0000_0000, 5)},
       { '6', (0b0001_0000, 5)},
       { '7', (0b0001_1000, 5)},
       { '8', (0b0001_1100, 5)},
       { '9', (0b0001_1110, 5)},
       { '.', (0b0001_0101, 6)},
       { ',', (0b0011_0011, 6)},
       { '?', (0b0000_1100, 6)},
       { '@', (0b0001_1010, 6) }
    };


    public string GetMorsecodeZeichen(char zeichen)
    {
        _ = zeichen;
        return "";
    }
    public IEnumerable<char> GetMorsecodeWoerter(string? s)
    {
        _ = s;
        return "";
    }
    public List<(char zeichen, string morsecode)>? GetMorsecodeSaetze(string? s)
    {
        _ = s;
        return []!;
    }
    public List<(char zeichen, string morsecode)>? GetMorsecodeListe() => _morseCodeListe;
}
