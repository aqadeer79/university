using System;
namespace StudentAPI.RabbitMQ
{
	public interface IMessageProducer
	{
		void SendMessage<T> (T Message);
	}
}

