using Projekt510.Model;

namespace Projekt510.Test;
public class HornerHexTesten
{
    public enum Testfaelle
    {
        Test0,
        Test1,
        Test5 = 3,
        Test13 = 5,
        Test42 = 7,
        Test12345 = 10
    }

    private readonly List<HornerSchema> _testergebnisse = new()
    {
        new HornerSchema("", 0, ""),    // Test0

        new HornerSchema("", 1, ""),    // Test1
        new HornerSchema("1", 0, "1"),

        new HornerSchema("", 5, ""),    // Test5
        new HornerSchema("1", 0, "5"),

        new HornerSchema("", 13, ""),    // Test13
        new HornerSchema("1", 0, "D"),

        new HornerSchema("", 42, ""),    // Test42
        new HornerSchema("1", 2, "A"),
        new HornerSchema("2", 0, "2"),

        new HornerSchema("", 12345, ""),  // Test 12345
        new HornerSchema("1", 771, "9"),
        new HornerSchema("2", 48, "3"),
        new HornerSchema("3", 3, "0"),
        new HornerSchema("4", 0, "3")
    };


    [Theory]
    [InlineData(Testfaelle.Test0, 1, 0, 0)]
    [InlineData(Testfaelle.Test1, 2, 1, 1)]
    [InlineData(Testfaelle.Test5, 2, 5, 1)]
    [InlineData(Testfaelle.Test13, 2, 13, 1)]
    [InlineData(Testfaelle.Test42, 3, 42, 1)]
    [InlineData(Testfaelle.Test12345, 5, 12345, 2)]


    public void DezimalToHexTesten(Testfaelle testFall, int anzahlEintraege, int dezimal, int anzahlByte)
    {
        var (_, horner) = Umrechnungen.DezimalToHexadezimal(dezimal, anzahlByte, Umrechnungen.Zahlensystem.HexadezimalC);

        for (var i = 0; i < anzahlEintraege; i++)
        {
            Assert.Equal(_testergebnisse[(int) testFall + i].Schritt, horner[i].Schritt);
            Assert.Equal(_testergebnisse[(int) testFall + i].DezimaleZahl, horner[i].DezimaleZahl);
            Assert.Equal(_testergebnisse[(int) testFall + i].Rest, horner[i].Rest);
        }
    }
}
