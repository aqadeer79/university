using System;
namespace StudentAPI
{
	public class ConsulConfig
	{
		public required string ConsulHost { get; set; }
		public int ConsulPort { get; set; }
		public required string ServiceName { get; set; }
		public required string ServiceId { get; set; }
	}
}

