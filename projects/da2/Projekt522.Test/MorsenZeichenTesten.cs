using Projekt522.Model;

namespace Projekt522.Test;

public class MorsenTestenFixture
{
    public ModelMorsen ModelMorsen { get; set; } = new();
}


public class MorsenZeichenTesten(MorsenTestenFixture fixture) : IClassFixture<MorsenTestenFixture>
{
    [Theory]
    [InlineData("• —", 'A')]
    [InlineData("• —", 'a')]
    [InlineData("— • • •", 'b')]
    [InlineData("— • • •", 'B')]
    [InlineData("— • — •", 'C')]
    [InlineData("— • •", 'D')]
    [InlineData("•", 'E')]
    [InlineData("• • — •", 'F')]
    [InlineData("— — •", 'G')]
    [InlineData("• • • •", 'H')]
    [InlineData("• •", 'I')]
    [InlineData("• — — —", 'J')]
    [InlineData("— • —", 'K')]
    [InlineData("• — • •", 'L')]
    [InlineData("— —", 'M')]
    [InlineData("— •", 'N')]
    [InlineData("— — —", 'O')]
    [InlineData("• — — •", 'P')]
    [InlineData("— — • —", 'Q')]
    [InlineData("• — •", 'R')]
    [InlineData("• • •", 'S')]
    [InlineData("—", 'T')]
    [InlineData("• • —", 'U')]
    [InlineData("• • • —", 'V')]
    [InlineData("• — —", 'W')]
    [InlineData("— • • —", 'X')]
    [InlineData("— • — —", 'Y')]
    [InlineData("— — • •", 'Z')]
    [InlineData("— — — — —", '0')]
    [InlineData("• — — — —", '1')]
    [InlineData("• • — — —", '2')]
    [InlineData("• • • — —", '3')]
    [InlineData("• • • • —", '4')]
    [InlineData("• • • • •", '5')]
    [InlineData("— • • • •", '6')]
    [InlineData("— — • • •", '7')]
    [InlineData("— — — • •", '8')]
    [InlineData("— — — — •", '9')]
    [InlineData("• — • — • —", '.')]
    [InlineData("— — • • — —", ',')]
    [InlineData("• • — — • •", '?')]
    [InlineData("• — — • — •", '@')]

    public void MorsenZeichenTest(string exp, char c)
    {
        var morsecode = fixture.ModelMorsen.GetMorsecodeZeichen(c);

        Assert.Equal(exp, morsecode);
    }
}
