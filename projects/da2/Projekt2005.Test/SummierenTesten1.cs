using System.Windows.Input;
using Xunit;

namespace Projekt2005.Test;

public class SummierenTesten1(SpielTestenFixture fixture) : IClassFixture<SpielTestenFixture>
{

    //          | 1 |   |   |   |  
    //          | 1 |   |   |   |
    //          |   |   | 2 | 2 |  
    //          |   |   |   |   |

    private readonly List<int[,]> _alleSpiele =
    [
        new[,] { { 1, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 2, 0, 0 }, { 0, 2, 0, 0 } },
        new[,] { { 2, 0, 0, 0 }, { 0, 0, 0, 0 }, { 2, 0, 0, 0 }, { 2, 0, 0, 0 } },  // Key.Up
        new[,] { { 0, 0, 0, 2 }, { 0, 0, 0, 0 }, { 0, 0, 0, 2 }, { 0, 0, 0, 2 } },  // Key.Down
        new[,] { { 1, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 4, 0, 0 }, { 0, 0, 0, 0 } },  // Key.Left
        new[,] { { 0, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 1, 4, 0, 0 } }   // Key.Right
    ];

    [Theory]
    [InlineData(ImportExportTesten.Spiele.Spiel1, Key.Space)]
    [InlineData(ImportExportTesten.Spiele.Spiel2, Key.Up)]
    [InlineData(ImportExportTesten.Spiele.Spiel3, Key.Down)]
    [InlineData(ImportExportTesten.Spiele.Spiel4, Key.Left)]
    [InlineData(ImportExportTesten.Spiele.Spiel5, Key.Right)]

    public void Test2024(ImportExportTesten.Spiele exp, Key key)
    {
        fixture.Model2024?.ImportSpielfeld(_alleSpiele[(int) ImportExportTesten.Spiele.Spiel1]);
        fixture.Model2024?.OnButtonKeyDown(key, true);
        var export = fixture.Model2024?.ExportSpielfeld();

        Assert.Equal(export, _alleSpiele[(int) exp]);
    }
}
