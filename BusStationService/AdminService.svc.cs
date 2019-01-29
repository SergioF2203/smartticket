using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusStationService.Lib;

namespace BusStationService
{
	public class AdminService : IAdminService
	{
		public string DoWork()
		{
			return "All work in Admin service!";
		}

		public Bus SecondOperation()
		{
			return new Bus
			{
				Capacity = 34,
				Model = "Jiguli",
				RegNumber = "FH87458745",
			};
		}
	}
}
