namespace Projekt102.Test;

public class ByteAddieren
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 0, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(200, 100, 100)]
    [InlineData(144, 200, 200)]

    public void ZweiByteAddieren(byte exp, byte summand1, byte summand2)
    {
        var ergebnis = GrundrechenartenByte.Addieren(summand1, summand2);

        Assert.Equal(exp, ergebnis);
    }
}
