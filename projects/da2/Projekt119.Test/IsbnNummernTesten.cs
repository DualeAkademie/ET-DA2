namespace Projekt119.Test;

public class IsbnNummernTesten
{
    [Theory]
    [InlineData(false, null)]
    [InlineData(false, "")]
    [InlineData(false, "978-3-12-732320-7")]
    [InlineData(false, "isbn 978-3-12-732320-7")]
    [InlineData(false, "ISBN978-3-12-732320-7")]

    [InlineData(true, "ISBN 978-3-12-732320-7")]
    [InlineData(true, "ISBN 1774266385")]
    [InlineData(true, "ISBN 978-1774266380")]
    [InlineData(true, "ISBN 1-23456-789-X")]

    public void TestIsbnNummer(bool exp, string? isbn)
    {
        var ok = IsbnNummern.NummerTesten(isbn);

        Assert.Equal(exp, ok);
    }
}
