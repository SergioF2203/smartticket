using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BusStationService;

namespace Host
{
	class AdminHost
	{
		internal static ServiceHost AdminServiceHost = null;
		internal static void StartService()
		{
			AdminServiceHost = new ServiceHost(typeof(AdminService));
			AdminServiceHost.Open();
		}

		internal static void StopService()
		{
			if (AdminServiceHost.State != CommunicationState.Closed)
				AdminServiceHost.Close();
		}
	}
}
