using System.Windows.Input;
using Xunit;
using static Projekt2005.Test.ImportExportTesten;

namespace Projekt2005.Test;

public class PfeiltastenTesten(SpielTestenFixture fixture) : IClassFixture<SpielTestenFixture>
{

    //          | 1 |   |   |   |  
    //          |   | 2 |   |   |
    //          |   |   | 4 |   |  
    //          |   |   |   | 8 |

    private readonly List<int[,]> _alleSpiele =
    [
        new[,] { { 1, 0, 0, 0 }, { 0, 2, 0, 0 }, { 0, 0, 4, 0 }, { 0, 0, 0, 8 } },
        new[,] { { 1, 0, 0, 0 }, { 2, 0, 0, 0 }, { 4, 0, 0, 0 }, { 8, 0, 0, 0 } },  // Key.Up
        new[,] { { 0, 0, 0, 1 }, { 0, 0, 0, 2 }, { 0, 0, 0, 4 }, { 0, 0, 0, 8 } },  // Key.Down
        new[,] { { 1, 2, 4, 8 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } },  // Key.Left
        new[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 1, 2, 4, 8 } }   // Key.Right
    ];

    [Theory]
    [InlineData(Spiele.Spiel1, Key.Space)]
    [InlineData(Spiele.Spiel2, Key.Up)]
    [InlineData(Spiele.Spiel3, Key.Down)]
    [InlineData(Spiele.Spiel4, Key.Left)]
    [InlineData(Spiele.Spiel5, Key.Right)]

    public void Test2024(Spiele exp, Key key)
    {
        fixture.Model2024?.ImportSpielfeld(_alleSpiele[(int) Spiele.Spiel1]);
        fixture.Model2024?.OnButtonKeyDown(key, true);
        var export = fixture.Model2024?.ExportSpielfeld();

        Assert.Equal(export, _alleSpiele[(int) exp]);
    }


}