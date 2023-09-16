namespace Projekt102.Test;
public class ByteMultiplizieren
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 0, 1)]
    [InlineData(1, 1, 1)]
    [InlineData(100, 10, 10)]
    [InlineData(144, 20, 20)]

    public void ZweiByteMultiplizieren(byte exp, byte multiplikand, byte multiplikator)
    {
        var produkt = GrundrechenartenByte.Multiplizieren(multiplikand, multiplikator);

        Assert.Equal(exp, produkt);
    }

}
