using Projekt510.Model;

namespace Projekt510.Test;

public class HornerBinTesten
{
    public enum Testfaelle
    {
        Test0,
        Test1,
        Test5 = 3,
        Test13 = 7,
        Test42 = 12
    }

    private readonly List<HornerSchema> _testergebnisse = new()
    {
        new HornerSchema("", 0, ""),    // Test0

        new HornerSchema("", 1, ""),    // Test1
        new HornerSchema("1", 0, "1"),

        new HornerSchema("", 5, ""),    // Test5
        new HornerSchema("1", 2, "1"),
        new HornerSchema("2", 1, "0"),
        new HornerSchema("3", 0, "1"),

        new HornerSchema("", 13, ""),    // Test13
        new HornerSchema("1", 6, "1"),
        new HornerSchema("2", 3, "0"),
        new HornerSchema("3", 1, "1"),
        new HornerSchema("4", 0, "1"),

        new HornerSchema("", 42, ""),    // Test42
        new HornerSchema("1", 21, "0"),
        new HornerSchema("2", 10, "1"),
        new HornerSchema("3", 5, "0"),
        new HornerSchema("4", 2, "1"),
        new HornerSchema("5", 1, "0"),
        new HornerSchema("6", 0, "1")
    };


    [Theory]
    [InlineData(Testfaelle.Test0, 1, 0, 0)]
    [InlineData(Testfaelle.Test1, 2, 1, 1)]
    [InlineData(Testfaelle.Test5, 4, 5, 1)]
    [InlineData(Testfaelle.Test13, 5, 13, 1)]
    [InlineData(Testfaelle.Test42, 7, 42, 1)]

    public void DezimalToBinTesten(Testfaelle testFall, int anzahlEintraege, int dezimal, int anzahlByte)
    {
        var (_, horner) = Umrechnungen.DezimalToBinaer(dezimal, anzahlByte, Umrechnungen.Zahlensystem.BinaerC);

        for (var i = 0; i < anzahlEintraege; i++)
        {
            Assert.Equal(_testergebnisse[(int) testFall + i].Schritt, horner[i].Schritt);
            Assert.Equal(_testergebnisse[(int) testFall + i].DezimaleZahl, horner[i].DezimaleZahl);
            Assert.Equal(_testergebnisse[(int) testFall + i].Rest, horner[i].Rest);
        }
    }
}
