using Confluent.Kafka;
using Newtonsoft.Json;
using System.Net;

var config = new ProducerConfig
{
    BootstrapServers = "host1:9092,host2:9092",
    ClientId = Dns.GetHostName()
};


using var producer = new ProducerBuilder<Null, string>(config).Build();
try
{
    string? state;
    while ((state = Console.ReadLine()) != null) 
    {

    }
    var response = producer.ProduceAsync("Weather-topic",
        new Message<Null, string> { Value = JsonConvert.SerializeObject(
            new Weather(state, 70))
        });
}
catch (ProduceException<Null,string>exc)
{
    Console.WriteLine(exc.Message);
}
public record Weather(string State, int Temparature);