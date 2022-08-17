using Confluent.Kafka;
using Newtonsoft.Json;
using System.Net;

var config = new ConsumerConfig
{
    BootstrapServers = "host:9092",
    GroupId = "weather-consumer-group",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
consumer.Subscribe("weather-topic");
CancellationTokenSource token = new();
try
{
    while (true)
    {
        var response = consumer.Consume(token.Token);
        if (response.Message == null)
        {
            var weather = JsonConvert.DeserializeObject<Weather>(response.Message.Value);
            Console.WriteLine($"Sate: {weather.State}, " + $"Temp:{weather.Temparature}F");
        }
    }
}
catch
{
     
}
public record Weather(string State, int Temparature);