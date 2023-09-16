namespace Projekt102.Test;
public class MitByteRechnen
{
    [Theory]
    [InlineData(0, 0, 0, RechnenByte.RechenOpenerationen.Addieren)]
    [InlineData(20, 10, 10, RechnenByte.RechenOpenerationen.Addieren)]

    [InlineData(3, 5, 2, RechnenByte.RechenOpenerationen.Subtrahieren)]
    [InlineData(252, 1, 5, RechnenByte.RechenOpenerationen.Subtrahieren)]

    [InlineData(100, 10, 10, RechnenByte.RechenOpenerationen.Multiplizieren)]
    [InlineData(144, 20, 20, RechnenByte.RechenOpenerationen.Multiplizieren)]

    [InlineData(2, 5, 2, RechnenByte.RechenOpenerationen.Dividieren)]
    [InlineData(1, 7, 5, RechnenByte.RechenOpenerationen.Dividieren)]

    [InlineData(1, 5, 2, RechnenByte.RechenOpenerationen.RestBerechnen)]
    [InlineData(2, 7, 5, RechnenByte.RechenOpenerationen.RestBerechnen)]


    public void MitByteRechnenTesten(byte exp, byte a, byte b, RechnenByte.RechenOpenerationen openerationen)
    {
        var ergebnis = RechnenByte.RechenFunkionen(a, b, openerationen);

        Assert.Equal(exp, ergebnis);
    }
}
