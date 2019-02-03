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

		public Bus GetBusById(int id)
		{
			using (DB db = new DB())
			{
				Bus bus = db.Buses.Find(id);

				Helper.ShowMessage("AdminService", "GetBusById(int id)");

				return bus;
			}
		}

		public void SaveBus(Bus bus)
		{
			if (bus != null)
			{
				using (DB db = new DB())
				{
					db.Entry(bus).State = EntityState.Modified;
					db.SaveChanges();

					Helper.ShowMessage("AdminService", "SaveBus(Bus bus)");
				}
			}
		}
	}
}
