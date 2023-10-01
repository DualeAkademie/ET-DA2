namespace Projekt150.Test;

public class CaesarTesten
{
    [Theory]
    [InlineData(false, "", "ab", 0)]

    public void TestCaesar(bool expectedValid, string expectedVerschluesselt, string klarText, int schluessel)
    {
        _ = expectedValid;
        _ = expectedVerschluesselt;
        _ = klarText;
        _ = schluessel;
    }
}
