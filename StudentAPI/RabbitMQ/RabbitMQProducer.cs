using RabbitMQ.Client;
using Newtonsoft.Json;
using System.Text;

namespace StudentAPI.RabbitMQ
{
    public class RabbitMQProducer : IMessageProducer
    {
        public void SendMessage<T>(T Message)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            //channel.QueueDeclare("enroll");

            var json = JsonConvert.SerializeObject(Message);
            var body = Encoding.UTF8.GetBytes(json);

            channel.BasicPublish(exchange: "", routingKey: "enroll", body: body);
        }
    }
}

