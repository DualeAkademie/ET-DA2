using Projekt512.Model;

namespace Projekt512.Test;

public class BildDrehenTesten
{
    public enum Testfaelle
    {
        Test3X3 = 0,
        Test4X4,
        Test5X5,
        Test6X6
    }

    private readonly List<int[,]> _arrayAngaben =
    [
        new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
        new[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } },
        new[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } },
        new[,] { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24 }, { 25, 26, 27, 28, 29, 30 }, { 31, 32, 33, 34, 35, 36 } }
];

    private readonly List<List<int[,]>> _arrayLoesungen =
    [
        [
            new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, // Cw0
            new[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } }, // Cw90
            new[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } }, // Cw180
            new[,] { { 3, 6, 9 }, { 2, 5, 8 }, { 1, 4, 7 } }  // Cw270
        ],
        [
            new[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } },  // Cw0
            new[,] { { 13, 9, 5, 1 }, { 14, 10, 6, 2 }, { 15, 11, 7, 3 }, { 16, 12, 8, 4 } },  // Cw90
            new[,] { { 16, 15, 14, 13 }, { 12, 11, 10, 9 }, { 8, 7, 6, 5 }, { 4, 3, 2, 1 } },  // Cw180
            new[,] { { 4, 8, 12, 16 }, { 3, 7, 11, 15 }, { 2, 6, 10, 14 }, { 1, 5, 9, 13 } }   // Cw270
        ],
        [
            new[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } },    // Cw0
            new[,] { { 21, 16, 11, 6, 1 }, { 22, 17, 12, 7, 2 }, { 23, 18, 13, 8, 3 }, { 24, 19, 14, 9, 4 }, { 25, 20, 15, 10, 5 } },    // Cw90
            new[,] { { 25, 24, 23, 22, 21 }, { 20, 19, 18, 17, 16 }, { 15, 14, 13, 12, 11 }, { 10, 9, 8, 7, 6 }, { 5, 4, 3, 2, 1 } },    // Cw180
            new[,] { { 5, 10, 15, 20, 25 }, { 4, 9, 14, 19, 24 }, { 3, 8, 13, 18, 23 }, { 2, 7, 12, 17, 22 }, { 1, 6, 11, 16, 21 } }     // Cw270
        ],
        [
            new[,] { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24 }, { 25, 26, 27, 28, 29, 30 }, { 31, 32, 33, 34, 35, 36 } },  // Cw0
            new[,] { { 31, 25, 19, 13, 7, 1 }, { 32, 26, 20, 14, 8, 2 }, { 33, 27, 21, 15, 9, 3 }, { 34, 28, 22, 16, 10, 4 }, { 35, 29, 23, 17, 11, 5 }, { 36, 30, 24, 18, 12, 6 } },  // Cw90
            new[,] { { 36, 35, 34, 33, 32, 31 }, { 30, 29, 28, 27, 26, 25 }, { 24, 23, 22, 21, 20, 19 }, { 18, 17, 16, 15, 14, 13 }, { 12, 11, 10, 9, 8, 7 }, { 6, 5, 4, 3, 2, 1 } },  // Cw180
            new[,] { { 6, 12, 18, 24, 30, 36 }, { 5, 11, 17, 23, 29, 35 }, { 4, 10, 16, 22, 28, 34 }, { 3, 9, 15, 21, 27, 33 }, { 2, 8, 14, 20, 26, 32 }, { 1, 7, 13, 19, 25, 31 } }   // Cw270
        ]
    ];


    [Theory]
    [InlineData(Testfaelle.Test3X3, BildDrehen.Winkel.Cw0, BildDrehen.Winkel.Cw0)]
    [InlineData(Testfaelle.Test3X3, BildDrehen.Winkel.Cw90, BildDrehen.Winkel.Cw90)]
    [InlineData(Testfaelle.Test3X3, BildDrehen.Winkel.Cw180, BildDrehen.Winkel.Cw180)]
    [InlineData(Testfaelle.Test3X3, BildDrehen.Winkel.Cw270, BildDrehen.Winkel.Cw270)]
    [InlineData(Testfaelle.Test3X3, BildDrehen.Winkel.Cw270, BildDrehen.Winkel.Ccw90)]
    [InlineData(Testfaelle.Test3X3, BildDrehen.Winkel.Cw180, BildDrehen.Winkel.Ccw180)]
    [InlineData(Testfaelle.Test3X3, BildDrehen.Winkel.Cw90, BildDrehen.Winkel.Ccw270)]


    [InlineData(Testfaelle.Test4X4, BildDrehen.Winkel.Cw0, BildDrehen.Winkel.Cw0)]
    [InlineData(Testfaelle.Test4X4, BildDrehen.Winkel.Cw90, BildDrehen.Winkel.Cw90)]
    [InlineData(Testfaelle.Test4X4, BildDrehen.Winkel.Cw180, BildDrehen.Winkel.Cw180)]
    [InlineData(Testfaelle.Test4X4, BildDrehen.Winkel.Cw270, BildDrehen.Winkel.Cw270)]
    [InlineData(Testfaelle.Test4X4, BildDrehen.Winkel.Cw270, BildDrehen.Winkel.Ccw90)]
    [InlineData(Testfaelle.Test4X4, BildDrehen.Winkel.Cw180, BildDrehen.Winkel.Ccw180)]
    [InlineData(Testfaelle.Test4X4, BildDrehen.Winkel.Cw90, BildDrehen.Winkel.Ccw270)]

    [InlineData(Testfaelle.Test5X5, BildDrehen.Winkel.Cw0, BildDrehen.Winkel.Cw0)]
    [InlineData(Testfaelle.Test5X5, BildDrehen.Winkel.Cw90, BildDrehen.Winkel.Cw90)]
    [InlineData(Testfaelle.Test5X5, BildDrehen.Winkel.Cw180, BildDrehen.Winkel.Cw180)]
    [InlineData(Testfaelle.Test5X5, BildDrehen.Winkel.Cw270, BildDrehen.Winkel.Cw270)]
    [InlineData(Testfaelle.Test5X5, BildDrehen.Winkel.Cw270, BildDrehen.Winkel.Ccw90)]
    [InlineData(Testfaelle.Test5X5, BildDrehen.Winkel.Cw180, BildDrehen.Winkel.Ccw180)]
    [InlineData(Testfaelle.Test5X5, BildDrehen.Winkel.Cw90, BildDrehen.Winkel.Ccw270)]

    [InlineData(Testfaelle.Test6X6, BildDrehen.Winkel.Cw0, BildDrehen.Winkel.Cw0)]
    [InlineData(Testfaelle.Test6X6, BildDrehen.Winkel.Cw90, BildDrehen.Winkel.Cw90)]
    [InlineData(Testfaelle.Test6X6, BildDrehen.Winkel.Cw180, BildDrehen.Winkel.Cw180)]
    [InlineData(Testfaelle.Test6X6, BildDrehen.Winkel.Cw270, BildDrehen.Winkel.Cw270)]
    [InlineData(Testfaelle.Test6X6, BildDrehen.Winkel.Cw270, BildDrehen.Winkel.Ccw90)]
    [InlineData(Testfaelle.Test6X6, BildDrehen.Winkel.Cw180, BildDrehen.Winkel.Ccw180)]
    [InlineData(Testfaelle.Test6X6, BildDrehen.Winkel.Cw90, BildDrehen.Winkel.Ccw270)]

    public void BildRotierenTesten(Testfaelle testFall, BildDrehen.Winkel winkelExpected, BildDrehen.Winkel winkelTest)
    {
        var ergebnis = BildDrehen.BildRotieren(_arrayAngaben[(int) testFall], winkelTest);

        Assert.Equal(_arrayLoesungen[(int) testFall][(int) winkelExpected], ergebnis);
    }
}
