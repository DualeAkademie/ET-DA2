namespace Projekt108;
public class RoemischeZahlen
{
    private static readonly (uint Wert, string ZahlenSchrift)[] s_roemischeZahlenSchrift = {
        (1000,  "M"),
        (900,  "CM"),
        (500,  "D"),
        (400,  "CD"),
        (100,  "C"),
        (90,  "XC"),
        (50,  "L"),
        (40,  "XL"),
        (10,  "X"),
        (9,  "IX"),
        (5,  "V"),
        (4,  "IV"),
        (1,  "I")
    };

    public static uint RoemischInDezimalUmrechnen(string? roemisch)
    {
        return 0;
    }
    public static string DezimalInRoemischUmrechnen(uint dezimal)
    {
        return "?";
    }
}