namespace Projekt104.Test;

public class TestTemperaturUmrechnungen
{
    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    public void TestCelsiusToFahrenheit(double exp, double celsius)
    {
        var fahrenheit = TemperaturUmrechnungen.ConvertCelsiusToFahrenheit(celsius);
        Assert.Equal(exp, fahrenheit);
    }

    [Theory]
    [InlineData(273.15, 0)]
    [InlineData(373.15, 100)]
    public void TestCelsiusToKelvin(double exp, double celsius)
    {
        var kelvin = TemperaturUmrechnungen.ConvertCelsiusToKelvin(celsius);
        Assert.Equal(exp, kelvin);
    }


    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]

    public void TestFahrenheitToCelsius(double exp, double fahrenheit)
    {
        var celsius = TemperaturUmrechnungen.ConvertFahrenheitToCelsius(fahrenheit);
        Assert.Equal(exp, celsius);
    }

    [Theory]
    [InlineData(273.15, 32)]
    [InlineData(373.15, 212)]
    public void TestFahrenheitToKelvin(double exp, double fahrenheit)
    {
        var celsius = TemperaturUmrechnungen.ConvertFahrenheitToKelvin(fahrenheit);
        Assert.Equal(exp, celsius);
    }


    [Theory]
    [InlineData(0, 273.15)]
    [InlineData(100, 373.15)]
    public void TestKelvinToCelsius(double exp, double kelvin)
    {
        var celsius = TemperaturUmrechnungen.ConvertKelvinToCelsius(kelvin);
        Assert.Equal(exp, celsius);
    }


    [Theory]
    [InlineData(32, 273.15)]
    [InlineData(212, 373.15)]
    public void TestKelvinToFahrenheit(double exp, double celsius)
    {
        var fahrenheit = TemperaturUmrechnungen.ConvertKelvinToFahrenheit(celsius);
        Assert.Equal(exp, fahrenheit);
    }


    [Theory]
    [InlineData(32, 0, TemperaturUmrechnungen.TemperaturOperation.CelsiusToFahrenheit)]
    [InlineData(212, 100, TemperaturUmrechnungen.TemperaturOperation.CelsiusToFahrenheit)]

    [InlineData(273.15, 0, TemperaturUmrechnungen.TemperaturOperation.CelsiusToKelvin)]
    [InlineData(373.15, 100, TemperaturUmrechnungen.TemperaturOperation.CelsiusToKelvin)]

    [InlineData(0, 32, TemperaturUmrechnungen.TemperaturOperation.FahrenheitToCelsius)]
    [InlineData(100, 212, TemperaturUmrechnungen.TemperaturOperation.FahrenheitToCelsius)]

    [InlineData(273.15, 32, TemperaturUmrechnungen.TemperaturOperation.FahrenheitToKelvin)]
    [InlineData(373.15, 212, TemperaturUmrechnungen.TemperaturOperation.FahrenheitToKelvin)]

    [InlineData(0, 273.15, TemperaturUmrechnungen.TemperaturOperation.KelvinToCelsius)]
    [InlineData(100, 373.15, TemperaturUmrechnungen.TemperaturOperation.KelvinToCelsius)]

    [InlineData(32, 273.15, TemperaturUmrechnungen.TemperaturOperation.KelvinToFahrenheit)]
    [InlineData(212, 373.15, TemperaturUmrechnungen.TemperaturOperation.KelvinToFahrenheit)]

    public void TestTemperaturUmrechnen(double exp, double temperatur, TemperaturUmrechnungen.TemperaturOperation operation)
    {
        var ergebnis = TemperaturUmrechnungen.ConvertTemperature(temperatur, operation);
        Assert.Equal(exp, ergebnis);
    }
}
