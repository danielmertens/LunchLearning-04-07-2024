using System.Text.Json;
using System.Text.Json.Serialization;

var forecast = new WeatherForecast
{
    Date = DateTime.Now,
    TemperatureCelsius = 15,
    Summary = "Cloudy"
};

var json = JsonSerializer.Serialize(forecast, SourceGenerationContext.Default.WeatherForecast);

Console.WriteLine(json);

var deserializedForecast = JsonSerializer.Deserialize(json, SourceGenerationContext.Default.WeatherForecast);

public class WeatherForecast
{
    public DateTime Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
}

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(WeatherForecast))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
}