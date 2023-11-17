namespace Projekt150.Test;

public class CaesarTesten
{
    [Theory]
    [InlineData(false, "", "ab", -1)]
    
    public void TestCaesar(bool expectedValid, string expectedVerschluesselt, string? klarText, int schluessel)
    {
        _ = expectedValid;
        _ = expectedVerschluesselt;
        _ = klarText;
        _ = schluessel;
    }


    [Theory]
    [InlineData(true, null, 0)]
    [InlineData(false, "ab", -1)]

    public void TestCaesarException(bool exception, string? klarText, int schluessel)
    {
        _ = exception;
        _= klarText;
        _ = schluessel;
    }
}
