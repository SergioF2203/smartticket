using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusStationService.Lib;
using System.Data.Entity;

namespace BusStationService
{
	public class AdminService : IAdminService
	{
		public void AddBus(Bus bus)
		{
			using (DB db = new DB())
			{
				db.Buses.Add(bus);
				db.SaveChanges();

				Helper.ShowMessage("AdminService", "called AddBus()");
			}
		}
	}
}
