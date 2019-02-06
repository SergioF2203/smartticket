using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		#region === Buses ===
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

		public List<Bus> GetAllBusses()
		{
			using (DB db = new DB())
			{
				var result = db.Buses.ToList();

				Helper.ShowMessage("AdminService", "GetAllBusses()");

				return result;
			}
		}

		public void DeleteBus(int id)
		{
			using (DB db = new DB())
			{
				Bus bus = db.Buses.Find(id);
				if (bus != null)
				{
					db.Buses.Remove(bus);
					db.SaveChanges();
				}

				Helper.ShowMessage("AdminService", "DeleteBus(int id)");
			}
		}
		#endregion

		#region === Directions ===

		public List<Direction> GetAllDirections()
		{
			using (DB db = new DB())
			{
				var result = db.Directions.ToList();

				Helper.ShowMessage("AdminService", "GetAllDirections()");

				return result;
			}
		}

		public void SaveDirections(List<Direction> directions)
		{
			using (DB db = new DB())
			{
				foreach (var d in directions)
				{
					if (d != null)
					{
						db.Entry(d).State = EntityState.Modified;
					}
				}

				db.SaveChanges();

				Helper.ShowMessage("AdminService", "SaveDirections(List<Direction> directions)");
			}
		}

		#endregion
	}
}
