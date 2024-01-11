namespace Projekt522.Test;

public class MorsenWoerterTesten(PvTestenFixture fixture) : IClassFixture<PvTestenFixture>
{
    private const string Buchstabenabstand = "   ";

    [Theory]
    [InlineData("• • •" + Buchstabenabstand + "— — —" + Buchstabenabstand + "• • •", "SOS")]
    [InlineData("• • •" + Buchstabenabstand + "— • — •" + Buchstabenabstand + "• • • •" + Buchstabenabstand + "• • —" + Buchstabenabstand + "• — • •" + Buchstabenabstand + "•", "Schule")]

    public void MorsenWoerterTest(string exp, string? s)
    {
        var morsecode = fixture.ModelMorsen.GetMorsecodeWoerter(s);

        Assert.Equal(exp, morsecode);
    }
}
