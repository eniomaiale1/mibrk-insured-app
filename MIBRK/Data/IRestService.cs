using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MIBRK
{
	public interface IRestService
	{
		Task<List<Policy>> RefreshPoliciesListAsync(string email);
	}
}
