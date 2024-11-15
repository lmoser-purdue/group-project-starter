using System;
using Xunit;

public class WeatherForecastTests
{
    [Fact]
    public void TemperatureF_CorrectlyCalculated()
    {
        // Arrange
        var date = DateOnly.FromDateTime(DateTime.Now);
        int temperatureC = 25; // Example Celsius temperature
        string summary = "Warm";
        var weatherForecast = new WeatherForecast(date, temperatureC, summary);

        // Act
        int expectedTemperatureF = 32 + (int)(temperatureC / 0.5556);

        // Assert
        Assert.Equal(expectedTemperatureF, weatherForecast.TemperatureF);
    }

    [Fact]
    public void Record_Initialization_PreservesValues()
    {
        // Arrange
        var date = DateOnly.FromDateTime(DateTime.Now);
        int temperatureC = -5; // Example Celsius temperature
        string summary = "Freezing";

        // Act
        var weatherForecast = new WeatherForecast(date, temperatureC, summary);

        // Assert
        Assert.Equal(date, weatherForecast.Date);
        Assert.Equal(temperatureC, weatherForecast.TemperatureC);
        Assert.Equal(summary, weatherForecast.Summary);
    }
}
