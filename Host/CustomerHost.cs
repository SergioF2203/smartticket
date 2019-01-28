using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BusStationService;

namespace Host
{
	class CustomerHost
	{
		internal static ServiceHost CustomerServiceHost = null;
		internal static void StartService()
		{
			CustomerServiceHost = new ServiceHost(typeof(CustomerService));
			CustomerServiceHost.Open();
		}

		internal static void StopService()
		{
			if (CustomerServiceHost.State != CommunicationState.Closed)
				CustomerServiceHost.Close();
		}
	}
}
