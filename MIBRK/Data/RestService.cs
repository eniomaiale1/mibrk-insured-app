using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace MIBRK
{
	public class RestService : IRestService
	{
		HttpClient client;

		public List<Policy> Policies { get; private set; }

		public RestService()
		{
			var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
			var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
		}

		public async Task<List<Policy>> RefreshPoliciesListAsync(string email)
		{
			Policies = new List<Policy>();

			// RestUrl = http://developer.xamarin.com:8081/api/todoitems{0}
			var uri = new Uri(string.Format(Constants.RestUrl, email));

			try
			{
				var response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					Policies = JsonConvert.DeserializeObject<List<Policy>>(content);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(@"				ERROR {0}", ex.Message);
			}

			return Policies;
		}
	}
}
