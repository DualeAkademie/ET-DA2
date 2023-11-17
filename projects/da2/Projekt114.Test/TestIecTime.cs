namespace Projekt114.Test;

public class TestIecTime
{
    private const long Time1Ms = 1;
    private const long Time1S = 1000 * Time1Ms;
    private const long Time1M = 60 * Time1S;
    private const long Time1H = 60 * Time1M;
    private const long Time1D = 24 * Time1H;

    [Theory]
    [InlineData(0, null)]
    [InlineData(0, "")]
    [InlineData(0, "?")]
    [InlineData(0, "T#0")]
    [InlineData(Time1Ms, "t#1MS")]
    [InlineData(Time1S, "T#1s")]
    [InlineData(Time1M, "t#1M")]
    [InlineData(Time1H, "T#1h")]
    [InlineData(Time1D, "t#1D")]
    [InlineData(Time1S + 500 * Time1Ms, "T#1S500Ms")]
    [InlineData(2 * Time1M + 10 * Time1S + 100 * Time1Ms, "t#2M10s100mS")]
    [InlineData(3 * Time1H + 5 * Time1M, "T#3H5m")]
    [InlineData(2 * Time1Ms + 3 * Time1S + 4 * Time1M + 5 * Time1H + 6 * Time1D, "t#2Ms3s4M5h6D")]

    public void TestIecTimeConverter(long exp, string? iecTime)
    {
        var time = IecTime.IecTimeConvertieren(iecTime);
        Assert.Equal(TimeSpan.FromMilliseconds(exp), time);
    }
}
