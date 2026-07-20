using Confluent.Kafka;
var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};
using var producer = new ProducerBuilder<Null, string>(config).Build();
Console.Write("Enter Message: ");
string msg = Console.ReadLine();
await producer.ProduceAsync("chat-message",
    new Message<Null, string> { Value = msg });
Console.WriteLine("Message Sent");
