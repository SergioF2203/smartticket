using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.CustomerService;

namespace Client
{
	public class DLCustomer
	{
		public CustomerServiceClient customerProxy;
		public DLCustomer()
		{
			customerProxy = new CustomerServiceClient();
		}

		public List<Direction> GetDirections()
		{
			Direction[] result = customerProxy.GetDirections();
			return result.ToList<Direction>();
		}


	}
}
