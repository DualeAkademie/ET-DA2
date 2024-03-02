using Xunit;

namespace Projekt2005.Test;



public class SpielTestenFixture
{
    public Model.Model? Model2024 { get; set; } = new();
}

public class ImportExportTesten(SpielTestenFixture fixture) : IClassFixture<SpielTestenFixture>
{
    public enum Spiele
    {
        Spiel1,
        Spiel2,
        Spiel3,
        Spiel4,
        Spiel5
    }

    //                              {   {       {       {       {   
    //          | 1 |   |   |   |       1,      0,      0,      0,
    //          |   | 2 |   |   |       0,      2,      0,      0,
    //          |   |   | 4 |   |       0,      0,      4,      0,
    //          |   |   |   | 8 |       0,      0,      0,      8,
    //                                  },      },      }       }   }   ====> das Array wird { {[0,0] .. [0,3]},     {[1,0] .. [1,3]},       {[2,0] .. [2,3]},       {[3,0] .. [3,3]} }        initialisiert 

    private readonly List<int[,]> _alleSpiele =
    [
        new[,] { { 1, 0, 0, 0 }, { 0, 2, 0, 0 }, { 0, 0, 4, 0 }, { 0, 0, 0, 8 } },
        new[,] { { 1, 0, 0, 0 }, { 2, 0, 0, 0 }, { 4, 0, 0, 0 }, { 8, 0, 0, 0 } },  // Key.Up
        new[,] { { 0, 0, 0, 1 }, { 0, 0, 0, 2 }, { 0, 0, 0, 4 }, { 0, 0, 0, 8 } },  // Key.Down
        new[,] { { 1, 2, 4, 8 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } },  // Key.Left
        new[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 1, 2, 4, 8 } }   // Key.Right
    ];

    [Theory]
    [InlineData(Spiele.Spiel1)]
    [InlineData(Spiele.Spiel2)]
    [InlineData(Spiele.Spiel3)]
    [InlineData(Spiele.Spiel4)]
    [InlineData(Spiele.Spiel5)]

    public void Test2024(Spiele spiel)
    {
        fixture.Model2024?.ImportSpielfeld(_alleSpiele[(int) spiel]);
        var export = fixture.Model2024?.ExportSpielfeld();

        Assert.Equal(export, _alleSpiele[(int) spiel]);
    }



}
