using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BusStationService
{
	public class CustomerService : ICustomerService
	{
		public string CustomerDoWork()
		{
			return "All ok in customer service!";
		}
	}
}
