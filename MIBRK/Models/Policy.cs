using System;
using Newtonsoft.Json;
namespace MIBRK
{
	public class Policy
	{
		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "effective")]
		public DateTime Effective { get; set; }

		[JsonProperty(PropertyName = "expiration")]
		public DateTime Expiration { get; set; }

		[JsonProperty(PropertyName = "insurer")]
		public string Insurer { get; set; }

		[JsonProperty(PropertyName = "policy_number")]
		public string PolicyNumber { get; set; }

		[JsonProperty(PropertyName = "agent")]
		public string Agent { get; set; }

		[JsonProperty(PropertyName = "premium")]
		public string Premium { get; set; }

		[JsonProperty(PropertyName = "image")]
		public string Image { get; set; }

		public Policy()
		{
		}
	}
}
