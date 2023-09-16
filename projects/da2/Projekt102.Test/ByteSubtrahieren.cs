namespace Projekt102.Test;

public class ByteSubtrahieren
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 1, 0)]
    [InlineData(3, 5, 2)]
    [InlineData(252, 1, 5)]

    public void ZweiByteSubtrahieren(byte exp, byte minuend, byte subtrahend)
    {
        var differenz = GrundrechenartenByte.Subtrahieren(minuend, subtrahend);

        Assert.Equal(exp, differenz);
    }
}
