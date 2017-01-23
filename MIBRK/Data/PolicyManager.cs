using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MIBRK
{
	public class PolicyManager
	{
		IRestService restService;

		public PolicyManager(IRestService service)
		{
			restService = service;
		}

		public Task<List<Policy>> GetPoliciesAsync(string email) {
			return restService.RefreshPoliciesListAsync(email);
		}
	}
}
