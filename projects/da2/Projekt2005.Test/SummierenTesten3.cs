using System.Windows.Input;
using Xunit;

namespace Projekt2005.Test;

public class SummierenTesten3(SpielTestenFixture fixture) : IClassFixture<SpielTestenFixture>
{

    //                              {   {       {       {       {   
    //          | 2 | 2 | 2 | 2 |       2,      2,      2,      2,
    //          | 2 |   |   |   |       2,      0,      0,      0,
    //          | 2 | 2 | 1 | 1 |       2,      2,      1,      1,
    //          | 2 | 1 | 4 | 4 |       2,      1,      4,      4,
    //                                  },      },      }       }   }   ====> das Array wird { {[0,0] .. [0,3]},     {[1,0] .. [1,3]},       {[2,0] .. [2,3]},       {[3,0] .. [3,3]} }        initialisiert 

    private readonly List<int[,]> _alleSpiele =
    [
        new[,] { { 2, 2, 2, 2 }, { 2, 0, 2, 1 }, { 2, 0, 1, 4 }, { 2, 0, 1, 4 } },
        new[,] { { 4, 4, 0, 0 }, { 4, 1, 0, 0 }, { 2, 1, 4, 0 }, { 2, 1, 4, 0 } },  // Key.Up
        new[,] { { 0, 0, 4, 4 }, { 0, 0, 4, 1 }, { 0, 2, 1, 4 }, { 0, 2, 1, 4 } },  // Key.Down
        new[,] { { 4, 2, 4, 2 }, { 4, 0, 2, 1 }, { 0, 0, 0, 8 }, { 0, 0, 0, 0 } },  // Key.Left
        new[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 2 }, { 4, 0, 4, 1 }, { 4, 2, 2, 8 } }   // Key.Right
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
